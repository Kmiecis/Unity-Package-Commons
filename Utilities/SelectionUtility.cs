#if UNITY_EDITOR
using System.IO;
using UnityEditor;

namespace Common
{
    public static class SelectionUtility
    {
        public static string GetActiveProjectPath()
        {
            var selectedObject = Selection.activeObject;

            if (selectedObject == null)
            {
                return null;
            }

            var path = AssetDatabase.GetAssetPath(selectedObject.GetInstanceID());

            if (!string.IsNullOrEmpty(path))
            {
                if (Directory.Exists(path))
                {
                    return path;
                }
                else
                {
                    return Path.GetDirectoryName(path);
                }
            }
            else
            {
                return null;
            }
        }
    }
}
#endif