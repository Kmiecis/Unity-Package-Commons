using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public class AVerticalPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            int defaultIndentLevel = EditorGUI.indentLevel;

            EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
            position.y += EditorGUI.GetPropertyHeight(property);

            foreach (SerializedProperty child in property)
            {
                position.height = EditorGUI.GetPropertyHeight(child);

                var next = child.Copy();
                var hasNext = next.Next(true);

                EditorGUI.indentLevel = child.depth;
                if (hasNext && next.depth > child.depth)
                    EditorGUI.LabelField(position, child.displayName);
                else
                    EditorGUI.PropertyField(position, child, new GUIContent(child.displayName));

                position.y += position.height;
            }

            EditorGUI.indentLevel = defaultIndentLevel;
            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            property = property.Copy();

            var result = EditorGUI.GetPropertyHeight(property);
            foreach (SerializedProperty child in property)
                result += EditorGUI.GetPropertyHeight(child);
            return result;
        }
    }
}
