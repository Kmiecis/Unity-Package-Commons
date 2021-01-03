using Common.Mathematics;
using CommonEditor;
using UnityEditor;

namespace Common.MathematicsEditor
{
	[CustomPropertyDrawer(typeof(Vector4Int))]
	public class Vector4IntDrawer : RepeatedPropertyDrawer
	{
		protected override int FieldCount => 4;
	}
}