using System.Collections.Generic;
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

        public static bool TryGetActive(out Object active)
        {
            active = Selection.activeObject;
            return active != null;
        }

        public static bool TryGetActive<T>(out T active)
            where T : Object
        {
            active = Selection.activeObject as T;
            return active != null;
        }

        public static IEnumerable<Object> GetSelected(bool warnings = false)
        {
            var selections = Selection.objects;
            if (selections != null)
            {
                foreach (var selected in selections)
                {
                    yield return selected;
                }
            }
            else if (warnings)
            {
                Debug.LogWarning("No objects selected");
            }
        }

        public static IEnumerable<T> GetSelected<T>(bool warnings = false)
            where T : Object
        {
            foreach (var selected in GetSelected(warnings))
            {
                if (selected is T casted)
                {
                    yield return casted;
                }
                else if (warnings)
                {
                    Debug.LogWarning($"Selected object {selected.name} is not of type {typeof(T)}");
                }
            }
        }
    }
}
