using Common;
using UnityEditor;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(Bool3))]
    public class Bool3Drawer : RepeatedPropertyDrawer
    {
        protected override int FieldCount => 3;
    }
}