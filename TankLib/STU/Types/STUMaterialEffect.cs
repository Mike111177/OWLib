// Instance generated by TankLibHelper.InstanceBuilder

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0x4D03ED2B, "STUMaterialEffect")]
    public class STUMaterialEffect : STUInstance {
        [STUFieldAttribute(0x0BCD10D6, "m_materialEffect")]
        public teStructuredDataAssetRef<STUMaterialEffect> m_materialEffect;

        [STUFieldAttribute(0xBAFDAFBA, "m_materials", ReaderType = typeof(InlineInstanceFieldReader))]
        public STUModelMaterial[] m_materials;
    }
}