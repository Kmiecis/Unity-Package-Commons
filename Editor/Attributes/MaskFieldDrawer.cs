using Common;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(MaskFieldAttribute))]
    public class MaskFieldDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (IsDrawerValid(property, out var error))
            {
                EditorGUI.BeginChangeCheck();

                var mask = EditorGUI.MaskField(position, label, property.intValue, property.enumNames);

                if (EditorGUI.EndChangeCheck())
                {
                    property.intValue = mask;
                }
            }
            else
            {
                EditorGUI.HelpBox(position, $"Error. {error}", MessageType.Error);
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, true);
        }

        private bool IsDrawerValid(SerializedProperty property, out string error)
        {
            if (property.propertyType != SerializedPropertyType.Enum)
            {
                error = $"Field [{property.name}] has to be of enum type.";
                return false;
            }

            error = default;
            return true;
        }
    }
}