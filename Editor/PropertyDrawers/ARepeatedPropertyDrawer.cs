#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public abstract class ARepeatedPropertyDrawer : PropertyDrawer
    {
        protected abstract int FieldCount
        {
            get;
        }

        protected virtual bool UseLabels
        {
            get => true;
        }

        protected object GetTarget(SerializedProperty property)
        {
            return fieldInfo.GetValue(property.serializedObject.targetObject);
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            label = EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            var copy = property.Copy();
            var labels = new GUIContent[FieldCount];
            var properties = new SerializedProperty[FieldCount];

            for (int i = 0; i < FieldCount && copy.Next(true); i++)
            {
                var current = copy.Copy();
                labels[i] = UseLabels ? new GUIContent(current.displayName) : GUIContent.none;
                properties[i] = current;
            }
            
            DrawPropertyFields(position, labels, properties, FieldCount);

            EditorGUI.EndProperty();
        }

        private static void DrawPropertyFields(Rect position, GUIContent[] labels, SerializedProperty[] properties, int count)
        {
            var indentLevel = EditorGUI.indentLevel;
            var labelWidth = EditorGUIUtility.labelWidth;

            var width = position.width / count;
            var contentPosition = new Rect(position.x, position.y, width, position.height);

            EditorGUI.indentLevel = 0;
            for (int i = 0; i < count; i++)
            {
                EditorGUIUtility.labelWidth = EditorStyles.label.CalcSize(labels[i]).x;
                EditorGUI.PropertyField(contentPosition, properties[i], labels[i]);
                contentPosition.x += width;
            }

            EditorGUIUtility.labelWidth = labelWidth;
            EditorGUI.indentLevel = indentLevel;
        }
    }
}
#endif