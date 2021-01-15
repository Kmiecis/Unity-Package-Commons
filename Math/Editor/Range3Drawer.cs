using Common;
using UnityEditor;

namespace CommonEditor
{
	[CustomPropertyDrawer(typeof(Range3))]
	public class Range3Drawer : ChildPropertyDrawer
	{
		private readonly string[] m_Children = new string[]
		{
			"min",
			"max"
		};

		public override string[] Children => m_Children;
	}
}