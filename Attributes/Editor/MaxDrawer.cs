#if UNITY_EDITOR
using Common;
using System;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(MaxAttribute))]
    public class MaxDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var attribute = (MaxAttribute)this.attribute;
            switch (property.propertyType)
            {
                case SerializedPropertyType.Float:
                    EditorGUI.PropertyField(position, property);
                    property.floatValue = Math.Max(property.floatValue, attribute.max);
                    break;

                case SerializedPropertyType.Integer:
                    EditorGUI.PropertyField(position, property);
                    property.intValue = Math.Max(property.intValue, Mathf.RoundToInt(attribute.max));
                    break;

                default:
                    EditorGUI.LabelField(position, label.text, $"Use {nameof(MaxAttribute)} with float or int.");
                    break;
            }
        }
    }
}
#endif
