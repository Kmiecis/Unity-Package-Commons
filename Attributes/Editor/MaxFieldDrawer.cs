#if UNITY_EDITOR
using Common;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(MaxFieldAttribute))]
    public class MaxFieldDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var attribute = (MaxFieldAttribute)this.attribute;
            switch (property.propertyType)
            {
                case SerializedPropertyType.Float:
                    EditorGUI.PropertyField(position, property);
                    if (property.floatValue > attribute.max)
                        property.floatValue = attribute.max;
                    break;

                case SerializedPropertyType.Integer:
                    EditorGUI.PropertyField(position, property);
                    if (property.intValue > attribute.max)
                        property.intValue = (int)attribute.max;
                    break;

                default:
                    EditorGUI.LabelField(position, label.text, $"Use {nameof(MaxFieldDrawer)} with values that can be max.");
                    break;
            }
        }
    }
}
#endif
