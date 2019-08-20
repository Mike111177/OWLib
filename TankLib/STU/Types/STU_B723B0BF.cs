// Instance generated by TankLibHelper.InstanceBuilder

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0xB723B0BF)]
    public class STU_B723B0BF : STUInstance {
        [STUFieldAttribute(0xB48F1D22, "m_name")]
        public teString m_name;

        [STUFieldAttribute(0xE46BDACB)]
        public teStructuredDataAssetRef<STUIdentifier>[] m_E46BDACB;

        [STUFieldAttribute(0x16B4863C, "m_entries", ReaderType = typeof(InlineInstanceFieldReader))]
        public STU_DA501E57[] m_entries;

        [STUFieldAttribute(0x925E7392)]
        public uint m_925E7392;
    }
}