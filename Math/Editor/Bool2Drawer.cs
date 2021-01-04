using Common.Mathematics;
using CommonEditor;
using UnityEditor;

namespace Common.MathematicsEditor
{
	[CustomPropertyDrawer(typeof(Bool2))]
	public class Bool2Drawer : RepeatedPropertyDrawer
	{
		protected override int FieldCount => 3;
	}
}