using Common.Mathematics;
using UnityEditor;

namespace CommonEditor.Mathematics
{
    [CustomPropertyDrawer(typeof(Bool3))]
    public class Bool3Drawer : ARepeatedPropertyDrawer
    {
        protected override int FieldCount => 3;
    }
}
