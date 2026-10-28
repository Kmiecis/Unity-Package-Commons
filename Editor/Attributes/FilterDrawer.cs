using Common;
using System;
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
        private static readonly Dictionary<int, string> Patterns;

        static FilterDrawer()
        {
            FilterContent = new GUIContent("Filter");
            Filters = new Dictionary<int, Regex>();
            Patterns = new Dictionary<int, string>();
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var filter = FindFilter(property);

            var pattern = FindPattern(property);
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

        private static string FindPattern(SerializedProperty property)
        {
            var hashCode = property.GetHashCodeForPropertyPath();
            return Patterns.TryGetValue(hashCode, out var pattern) ? pattern : string.Empty;
        }

        private static void UpdateFilter(SerializedProperty property, string pattern)
        {
            var hashCode = property.GetHashCodeForPropertyPath();
            if (pattern.IsNullOrEmpty())
            {
                Filters.Remove(hashCode);
                Patterns.Remove(hashCode);
            }
            else if (!Patterns.TryGetValue(hashCode, out var previous) || previous != pattern)
            {
                Filters[hashCode] = CreateFilter(pattern);
                Patterns[hashCode] = pattern;
            }
        }

        private static Regex CreateFilter(string pattern)
        {
            try
            {
                return new Regex(pattern);
            }
            catch (ArgumentException)
            {
                return new Regex(Regex.Escape(pattern));
            }
        }
    }
}