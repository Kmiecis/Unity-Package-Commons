using UnityEngine;

namespace Common
{
	public static class ComponentExtensions
	{
		public static bool HasComponent<T>(this Component component)
		{
			return component.GetComponent<T>() != null;
		}
	}
}