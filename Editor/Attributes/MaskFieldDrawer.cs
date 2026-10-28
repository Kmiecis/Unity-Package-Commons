using Common;
using System;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(MaskFieldAttribute))]
    public class MaskFieldDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var enumType = UEditorUtility.GetFieldType(fieldInfo);
            if (property.propertyType == SerializedPropertyType.Enum && enumType.IsEnum)
            {
                EditorGUI.BeginChangeCheck();

                var current = (Enum)Enum.ToObject(enumType, property.intValue);
                var mask = EditorGUI.EnumFlagsField(position, label, current);

                if (EditorGUI.EndChangeCheck())
                {
                    property.intValue = Convert.ToInt32(mask);
                }
            }
            else
            {
                Debug.LogWarning(this.Format("Requires enum type field"));
            }
        }
    }
}