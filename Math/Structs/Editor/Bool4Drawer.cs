#if UNITY_EDITOR
using Common;
using UnityEditor;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(Bool4))]
    public class Bool4Drawer : RepeatedPropertyDrawer
    {
        protected override int FieldCount => 4;
    }
}
#endif