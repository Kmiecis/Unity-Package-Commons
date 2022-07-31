#if UNITY_EDITOR
using Common.Mathematics;
using UnityEditor;

namespace CommonEditor.Mathematics
{
    [CustomPropertyDrawer(typeof(Bool3))]
    public class Bool3Drawer : RepeatedPropertyDrawer
    {
        protected override int FieldCount => 3;
    }
}
#endif