using UnityEngine;

namespace Common
{
	public static class ApplicationUtility
	{
		public static string ConvertToProjectPath(string filePath)
		{
			return "Assets" + filePath.RemovePrefix(Application.dataPath);
		}

		public static string ConvertToFilePath(string projectPath)
		{
			return Application.dataPath + projectPath.RemovePrefix("Assets");
		}
	}
}