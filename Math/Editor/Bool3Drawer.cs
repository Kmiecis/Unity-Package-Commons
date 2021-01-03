using Common.Mathematics;
using CommonEditor;
using UnityEditor;

namespace Common.MathematicsEditor
{
	[CustomPropertyDrawer(typeof(Bool3))]
	public class Bool3Drawer : RepeatedPropertyDrawer
	{
		protected override int FieldCount => 3;
	}
}