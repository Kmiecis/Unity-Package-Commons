using Common.Mathematics;
using CommonEditor;
using UnityEditor;

namespace Common.MathematicsEditor
{
	[CustomPropertyDrawer(typeof(Bool4))]
	public class Bool4Drawer : RepeatedPropertyDrawer
	{
		protected override int FieldCount => 4;
	}
}