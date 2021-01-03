using UnityEngine;

namespace Common
{
	public class MaxFieldAttribute : PropertyAttribute
	{
		public readonly float max;

		public MaxFieldAttribute(float max)
		{
			this.max = max;
		}
	}
}