// Instance generated by TankLibHelper.InstanceBuilder

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0x142AE6FA, "STUGraph")]
    public class STUGraph : STUInstance {
        [STUFieldAttribute(0x0ACD5C3D, ReaderType = typeof(InlineInstanceFieldReader))]
        public STU_CB38A8DE m_0ACD5C3D;

        [STUFieldAttribute(0x128F7430, "m_items", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUGraphItem[] m_items;

        [STUFieldAttribute(0x979E8BDE, "m_links", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUGraphLink[] m_links;

        [STUFieldAttribute(0x7E0BC920)]
        public uint m_7E0BC920;
    }
}
