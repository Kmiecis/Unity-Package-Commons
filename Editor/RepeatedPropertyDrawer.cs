#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public abstract class RepeatedPropertyDrawer : PropertyDrawer
    {
        private const float HORIZONTAL_SPACING = 4.0f;
        private const float VERTICAL_SPACING = 2.0f;

        protected abstract int FieldCount { get; }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.height -= VERTICAL_SPACING;

            label = EditorGUI.BeginProperty(position, label, property);

            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            var copy = property.Copy();
            var labels = new GUIContent[FieldCount];
            var properties = new SerializedProperty[FieldCount];

            for (int i = 0; i < FieldCount && copy.Next(true); i++)
            {
                var current = copy.Copy();
                labels[i] = new GUIContent(current.displayName);
                properties[i] = current;
            }
            
            DrawPropertyFields(position, labels, properties, FieldCount);

            EditorGUI.EndProperty();
        }

        private static void DrawPropertyFields(Rect position, GUIContent[] labels, SerializedProperty[] properties, int count)
        {
            var indentLevel = EditorGUI.indentLevel;
            var labelWidth = EditorGUIUtility.labelWidth;

            var width = (position.width - (count - 1) * HORIZONTAL_SPACING) / count;
            var contentPosition = new Rect(position.x, position.y, width, position.height);

            EditorGUI.indentLevel = 0;
            for (int i = 0; i < count; i++)
            {
                EditorGUIUtility.labelWidth = EditorStyles.label.CalcSize(labels[i]).x;
                EditorGUI.PropertyField(contentPosition, properties[i], labels[i]);
                contentPosition.x += width + HORIZONTAL_SPACING;
            }

            EditorGUIUtility.labelWidth = labelWidth;
            EditorGUI.indentLevel = indentLevel;
        }
    }
}
#endif