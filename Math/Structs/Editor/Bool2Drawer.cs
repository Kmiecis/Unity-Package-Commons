#if UNITY_EDITOR
using Common.Mathematics;
using UnityEditor;

namespace CommonEditor.Mathematics
{
    [CustomPropertyDrawer(typeof(Bool2))]
    public class Bool2Drawer : RepeatedPropertyDrawer
    {
        protected override int FieldCount => 2;
    }
}
#endif