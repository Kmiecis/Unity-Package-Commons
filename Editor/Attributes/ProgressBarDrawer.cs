using Common;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(ProgressBarAttribute))]
    public class ProgressBarDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.propertyType == SerializedPropertyType.Float)
            {
                if (property.floatValue >= 0.0f && property.floatValue < 1.0f)
                {
                    EditorGUI.ProgressBar(position, property.floatValue, property.displayName);
                }
            }
            else
            {
                Debug.LogWarning(this.Format("Requires float type field"));
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            if (property.propertyType == SerializedPropertyType.Float &&
                (property.floatValue < 0.0f || property.floatValue >= 1.0f))
            {
                return 0.0f;
            }
            return base.GetPropertyHeight(property, label);
        }
    }
}
