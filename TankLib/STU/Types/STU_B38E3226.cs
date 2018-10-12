// Instance generated by TankLibHelper.InstanceBuilder
using TankLib.Math;

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0xB38E3226)]
    public class STU_B38E3226 : STUAnimGameData_Base {
        [STUFieldAttribute(0x44B8E377)]
        public teVec3A m_44B8E377;

        [STUFieldAttribute(0x2A195E35)]
        public teVec3A m_2A195E35;

        [STUFieldAttribute(0xF9CA7995, "m_paramIds")]
        public uint[] m_paramIds;

        [STUFieldAttribute(0xA76B4746, ReaderType = typeof(InlineInstanceFieldReader))]
        public STUAnimGameData_PoseData[] m_A76B4746;

        [STUFieldAttribute(0xA867458D, ReaderType = typeof(InlineInstanceFieldReader))]
        public STU_CE2BEF36[] m_A867458D;

        [STUFieldAttribute(0x818D011C, "m_skeleton", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUAnimGameData_Skeleton m_skeleton;
    }
}
