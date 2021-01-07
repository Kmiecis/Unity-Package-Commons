using Common;
using UnityEditor;

namespace CommonEditor
{
	[CustomPropertyDrawer(typeof(Bool2))]
	public class Bool2Drawer : RepeatedPropertyDrawer
	{
		protected override int FieldCount => 2;
	}
}