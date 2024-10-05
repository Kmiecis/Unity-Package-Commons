using Common;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(LimitAttribute))]
    public class LimitDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var attribute = (LimitAttribute)this.attribute;
            switch (property.propertyType)
            {
                case SerializedPropertyType.Float:
                    EditorGUI.PropertyField(position, property, label);
                    property.floatValue = Mathf.Clamp(property.floatValue, attribute.min, attribute.max);
                    break;

                case SerializedPropertyType.Integer:
                    EditorGUI.PropertyField(position, property, label);
                    property.intValue = (int)Mathf.Clamp(property.intValue, attribute.min, attribute.max);
                    break;

                default:
                    EditorGUI.LabelField(position, label.text, $"Use {nameof(LimitAttribute)} with float or int.");
                    break;
            }
        }
    }
}
