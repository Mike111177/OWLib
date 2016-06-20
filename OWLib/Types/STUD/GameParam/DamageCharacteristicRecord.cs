﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace OWLib.Types.STUD.GameParam {
  public class DamageCharacteristicRecord : ISTUDInstance {
    public ulong Key
    {
      get
      {
        return 0xF6ED9C3A376B9B60;
      }
    }

    public string Name
    {
      get
      {
        return "GameParameter:DamageCharacteristic";
      }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct DamageCharacteristic {
      public STUDInstanceInfo instance;
      public ulong unk1;
      public ulong value;
      public ulong unk2;
    }

    private DamageCharacteristic characteristic;
    public DamageCharacteristic Characteristic => characteristic;

    public void Read(Stream input) {
      using(BinaryReader reader = new BinaryReader(input, System.Text.Encoding.Default, true)) {
        characteristic = reader.Read<DamageCharacteristic>();
      }
    }
  }
}