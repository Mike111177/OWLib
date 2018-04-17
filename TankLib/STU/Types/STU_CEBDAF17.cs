// Instance generated by TankLibHelper.InstanceBuilder

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0xCEBDAF17)]
    public class STU_CEBDAF17 : STU_DD856C32 {
        [STUFieldAttribute(0xBC4326FF)]
        public teStructuredDataAssetRef<STUStat> m_BC4326FF;

        [STUFieldAttribute(0x118D9D9F)]
        public teStructuredDataAssetRef<ulong>[] m_118D9D9F;

        [STUFieldAttribute(0xD32CB484)]
        public teStructuredDataAssetRef<ulong>[] m_D32CB484;

        [STUFieldAttribute(0xAF872E86, "m_amount", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUConfigVar m_amount;

        [STUFieldAttribute(0xE3798C00, "m_targets", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUConfigVar m_targets;
    }
}
