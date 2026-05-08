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
        private static readonly Dictionary<int, Regex> Filters;

        static FilterDrawer()
        {
            FilterContent = new GUIContent("Filter");
            Filters = new Dictionary<int, Regex>();
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var filter = FindFilter(property);

            var pattern = filter != null ? filter.ToString() : string.Empty;
            pattern = UEditorGUI.TextField(ref position, pattern, FilterContent);

            UpdateFilter(property, pattern);

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

            var filter = FindFilter(property);
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

        private static IEnumerable<SerializedProperty> GetFiltered(SerializedProperty property, Regex filter)
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

        private static bool MatchesFilter(SerializedProperty property, Regex filter)
        {
            return filter.IsMatch(property.displayName);
        }

        private static Regex FindFilter(SerializedProperty property)
        {
            var hashCode = property.GetHashCodeForPropertyPath();
            return Filters.TryGetValue(hashCode, out var filter) ? filter : null;
        }

        private static void UpdateFilter(SerializedProperty property, string pattern)
        {
            var hashCode = property.GetHashCodeForPropertyPath();
            if (pattern.IsNullOrEmpty())
            {
                Filters.Remove(hashCode);
            }
            else if (!Filters.TryGetValue(hashCode, out var filter) || filter.ToString() != pattern)
            {
                Filters[hashCode] = new Regex(pattern, RegexOptions.Compiled);
            }
        }
    }
}