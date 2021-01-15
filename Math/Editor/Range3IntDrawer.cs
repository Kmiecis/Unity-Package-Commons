using Common;
using UnityEditor;

namespace CommonEditor
{
	[CustomPropertyDrawer(typeof(Range3Int))]
	public class Range3IntDrawer : ChildPropertyDrawer
	{
		private readonly string[] m_Children = new string[]
		{
			"min",
			"max"
		};

		public override string[] Children => m_Children;
	}
}