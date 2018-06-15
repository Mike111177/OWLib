﻿using System;
using System.IO;
using System.Runtime.InteropServices;

namespace TankLib {
    /// <summary>Tank Material Data, file type 0B3</summary>
    public class teMaterialData {
        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct MatDataHeader {
            public long Offset1;
            public long Offset2;
            
            /// <summary>Texture definition offset</summary>
            public long TextureOffset;
            public long Offset4;
            public uint unk1;
            public ushort BufferPartCount;
            public ushort unk3;
            
            /// <summary>Texture definition count</summary>
            public byte TextureCount;
            
            public byte Offset4Count;
            public ushort unk4;
            public uint unk5;
        }

        /// <summary>Header data</summary>
        public MatDataHeader Header;
        
        /// <summary>Texture definitions</summary>
        public teMaterialDataTexture[] Textures;
        
        /// <summary>Unknown definitions</summary>
        public teMaterialDataUnknown[] Unknowns;

        /// <summary>Constant buffer definitions</summary>
        public teMaterialDataBufferPart[] BufferParts;

        /// <summary>Load material data from a stream</summary>
        public teMaterialData(Stream stream) {
            using (BinaryReader reader = new BinaryReader(stream)) {
                Header = reader.Read<MatDataHeader>();

                if (Header.TextureOffset > 0) {
                    reader.BaseStream.Position = Header.TextureOffset;
                    
                    Textures = reader.ReadArray<teMaterialDataTexture>(Header.TextureCount);
                }

                if (Header.Offset4 > 0) {
                    reader.BaseStream.Position = Header.Offset4;

                    Unknowns = reader.ReadArray<teMaterialDataUnknown>(Header.Offset4Count);
                }
                if (Header.Offset1 > 0) {
                    reader.BaseStream.Position = Header.Offset1;
                    BufferParts = new teMaterialDataBufferPart[Header.BufferPartCount];
                    for (int i = 0; i < Header.BufferPartCount; i++) {
                        BufferParts[i] = new teMaterialDataBufferPart(reader);
                    }
                }
            }
        }
    }

    public class teMaterialDataBufferPart {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct HeaderData {
            public uint Hash;
            public TestByteFlags Flags;
            public byte Size;
            public short Unknown;
        }

        public HeaderData Header;
        public byte[] Data;

        public teMaterialDataBufferPart(BinaryReader reader) {
            Header = reader.Read<HeaderData>();
            int size = Header.Size;
            byte intFlags = (byte) Header.Flags;

            if (intFlags == 10) {
                size *= 16;
            } else if (intFlags == 8) {
                size *= 8;
            } else if (intFlags == 11) {
                size *= 16;
            } else if (intFlags == 3) {
                size *= 4;
            } else if (intFlags == 2) {
                size *= 4;
            } else if (intFlags == 6) {
                size *= 4;
            } else if (intFlags == 9) {
                size *= 12;
            } else {
                throw new Exception($"teMaterialDataWeirdBuffer: Unsure how much to read for data ({intFlags}, flags: {Header.Flags}, offset: {reader.BaseStream.Position})");
            }

            Data = reader.ReadBytes(size);
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct teMaterialDataUnknown {
        public ulong A;
        public ulong B;
    }

    /// <summary>MaterialData Texture</summary>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct teMaterialDataTexture {
        /// <summary>Texture GUID</summary>
        /// <remarks>File type 004</remarks>
        public teResourceGUID Texture;
        
        /// <summary>CRC32 of input name</summary>
        /// <remarks>Matches up on teShaderInstance</remarks>
        public uint NameHash;
        
        /// <summary>Unknown flags</summary>
        public byte Flags;
    }
}