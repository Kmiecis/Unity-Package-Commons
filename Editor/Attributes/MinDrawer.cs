using System;
using UnityEditor;
using UnityEngine;
using MinAttribute = Common.MinAttribute;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(MinAttribute))]
    public class MinDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var attribute = (MinAttribute)this.attribute;
            switch (property.propertyType)
            {
                case SerializedPropertyType.Float:
                    EditorGUI.PropertyField(position, property, label);
                    property.floatValue = Math.Max(property.floatValue, attribute.min);
                    break;

                case SerializedPropertyType.Integer:
                    EditorGUI.PropertyField(position, property, label);
                    property.intValue = Math.Max(property.intValue, Mathf.RoundToInt(attribute.min));
                    break;

                default:
                    EditorGUI.LabelField(position, label.text, $"Use {nameof(MinAttribute)} with float or int.");
                    break;
            }
        }
    }
}
