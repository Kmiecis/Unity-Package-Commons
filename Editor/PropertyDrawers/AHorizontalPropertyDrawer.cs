using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public class AHorizontalPropertyDrawer : PropertyDrawer
    {
        // Required to match other Unity horizontal property drawers
        private const float kLabelMargin = 3.0f;
        private const float kLabelOffset = 1.0f;
        private const float kIndentWidth = 14.0f;
        //

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            var defaultLabelWidth = EditorGUIUtility.labelWidth;

            var postfixPosition = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
            if (!EditorGUIUtility.wideMode)
            {
                position.x += kIndentWidth;
                position.width -= kIndentWidth;
                position.y += EditorGUI.GetPropertyHeight(property);
            }
            else
            {
                position = postfixPosition;
            }

            var childCount = property.CountChildren();
            position.width = (position.width / childCount) - kLabelOffset * childCount;

            foreach (SerializedProperty child in property)
            {
                position.height = EditorGUI.GetPropertyHeight(child);

                var childLabel = new GUIContent(child.displayName);
                var childLabelWidth = EditorStyles.label.CalcSize(childLabel).x;

                EditorGUIUtility.labelWidth = childLabelWidth + kLabelMargin;
                EditorGUI.PropertyField(position, child, childLabel);

                position.x += position.width + kLabelOffset + kLabelMargin;
            }

            EditorGUIUtility.labelWidth = defaultLabelWidth;
            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            property = property.Copy();

            var result = EditorGUI.GetPropertyHeight(property, label, false);
            if (!EditorGUIUtility.wideMode)
                result += EditorGUIUtility.singleLineHeight;
            return result;
        }
    }
}
