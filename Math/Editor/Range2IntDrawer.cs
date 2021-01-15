using Common;
using UnityEditor;

namespace CommonEditor
{
	[CustomPropertyDrawer(typeof(Range2Int))]
	public class Range2IntDrawer : ChildPropertyDrawer
	{
		private readonly string[] m_Children = new string[]
		{
			"min",
			"max"
		};

		public override string[] Children => m_Children;
	}
}