using Common;
using UnityEditor;

namespace CommonEditor
{
	[CustomPropertyDrawer(typeof(Range2))]
	public class Range2Drawer : ChildPropertyDrawer
	{
		private readonly string[] m_Children = new string[]
		{
			"min",
			"max"
		};

		public override string[] Children => m_Children;
	}
}