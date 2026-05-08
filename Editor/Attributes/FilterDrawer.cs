using Common;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(FilterAttribute))]
    public class FilterDrawer : BasePropertyDrawer<FilterAttribute>
    {
        private static readonly GUIContent FilterContent;
        private static readonly Dictionary<int, string> Filters;

        static FilterDrawer()
        {
            FilterContent = new GUIContent("Filter");
            Filters = new Dictionary<int, string>();
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var filter = GetFilter(property);
            filter = UEditorGUI.TextField(ref position, filter, FilterContent);
            SetFilter(property, filter);

            if (filter != null)
            {
                foreach (var filtered in GetFiltered(property, filter))
                {
                    UEditorGUI.PropertyField(ref position, filtered, true);
                }
            }
            else
            {
                base.OnGUI(position, property, label);
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var result = UEditorGUI.GetTextHeight(FilterContent);

            var filter = GetFilter(property);
            if (filter != null)
            {
                foreach (var filtered in GetFiltered(property, filter))
                {
                    result += EditorGUI.GetPropertyHeight(filtered, true);
                }
            }
            else
            {
                result += base.GetPropertyHeight(property, label);
            }
            
            return result;
        }

        private static IEnumerable<SerializedProperty> GetFiltered(SerializedProperty property, string filter)
        {
            if (property.hasChildren)
            {
                foreach (var child in property.GetChildren())
                {
                    if (MatchesFilter(child, filter))
                    {
                        yield return child;
                    }
                    else
                    {
                        foreach (var filtered in GetFiltered(child, filter))
                        {
                            yield return filtered;
                        }
                    }
                }
            }
        }

        private static bool MatchesFilter(SerializedProperty property, string filter)
        {
            try { return Regex.IsMatch(property.displayName, filter); }
            catch { return false; }
        }

        private static string GetFilter(SerializedProperty property)
        {
            var hashCode = property.GetHashCodeForPropertyPath();
            return Filters.TryGetValue(hashCode, out var filter) ? filter : null;
        }

        private static void SetFilter(SerializedProperty property, string filter)
        {
            var hashCode = property.GetHashCodeForPropertyPath();
            if (filter.IsNullOrEmpty())
                Filters.Remove(hashCode);
            else
                Filters[hashCode] = filter;
        }
    }
}