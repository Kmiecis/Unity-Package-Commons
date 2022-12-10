using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public static class USelection
    {
        public static bool IsSelected(Object value)
        {
            return Selection.activeObject == value;
        }

        public static string GetActiveDirectory()
        {
            return UAssetDatabase.GetAssetDirectory(Selection.activeObject);
        }

        public static string GetActivePath()
        {
            return AssetDatabase.GetAssetPath(Selection.activeObject);
        }
    }
}
