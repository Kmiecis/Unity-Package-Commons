#if UNITY_EDITOR
using Common;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(MinFieldAttribute))]
    public class MinFieldDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var attribute = (MinFieldAttribute)this.attribute;
            switch (property.propertyType)
            {
                case SerializedPropertyType.Float:
                    EditorGUI.PropertyField(position, property);
                    if (property.floatValue < attribute.min)
                        property.floatValue = attribute.min;
                    break;

                case SerializedPropertyType.Integer:
                    EditorGUI.PropertyField(position, property);
                    if (property.intValue < attribute.min)
                        property.intValue = (int)attribute.min;
                    break;

                default:
                    EditorGUI.LabelField(position, label.text, $"Use {nameof(MinFieldDrawer)} with values that can be min.");
                    break;
            }
        }
    }
}
#endif
