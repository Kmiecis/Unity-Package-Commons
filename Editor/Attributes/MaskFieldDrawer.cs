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
            if (property.propertyType == SerializedPropertyType.Enum)
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
                Debug.LogWarning(this.Format("Requires enum type field"));
            }
        }
    }
}