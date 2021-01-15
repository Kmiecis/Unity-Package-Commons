using Common;
using UnityEditor;

namespace CommonEditor
{
	[CustomPropertyDrawer(typeof(RangeInt))]
	public class RangeIntDrawer : RepeatedPropertyDrawer
	{
		protected override int FieldCount => 2;
	}
}