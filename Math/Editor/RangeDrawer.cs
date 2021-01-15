using Common;
using UnityEditor;

namespace CommonEditor
{
	[CustomPropertyDrawer(typeof(Range))]
	public class RangeDrawer : RepeatedPropertyDrawer
	{
		protected override int FieldCount => 2;
	}
}