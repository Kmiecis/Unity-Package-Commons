using Common.Extensions;
using UnityEngine;

namespace Common
{
    public static class ApplicationUtility
    {
        public static string ToProjectPath(string filePath)
        {
            return "Assets" + filePath.RemovePrefix(Application.dataPath);
        }

        public static string ToFilePath(string projectPath)
        {
            return Application.dataPath + projectPath.RemovePrefix("Assets");
        }
    }
}
