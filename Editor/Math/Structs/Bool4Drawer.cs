#if UNITY_EDITOR
using Common.Mathematics;
using UnityEditor;

namespace CommonEditor.Mathematics
{
    [CustomPropertyDrawer(typeof(Bool4))]
    public class Bool4Drawer : RepeatedPropertyDrawer
    {
        protected override int FieldCount => 4;
    }
}
#endif