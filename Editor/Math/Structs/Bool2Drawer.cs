using Common.Mathematics;
using UnityEditor;

namespace CommonEditor.Mathematics
{
    [CustomPropertyDrawer(typeof(Bool2))]
    public class Bool2Drawer : ARepeatedPropertyDrawer
    {
        protected override int FieldCount => 2;
    }
}
