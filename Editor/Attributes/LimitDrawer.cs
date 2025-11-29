using Common;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(LimitAttribute))]
    public class LimitDrawer : BasePropertyDrawer<LimitAttribute>
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            base.OnGUI(position, property, label);

            ClampValue(property);
        }

        private void ClampValue(SerializedProperty property)
        {
            switch (property.propertyType)
            {
                case SerializedPropertyType.Float:
                    property.floatValue = Mathf.Clamp(property.floatValue, attribute.min, attribute.max);
                    break;

                case SerializedPropertyType.Integer:
                    property.intValue = (int)Mathf.Clamp(property.intValue, attribute.min, attribute.max);
                    break;

                default:
                    Debug.LogWarning(this.Format("Requires float or int type field"));
                    break;
            }
        }
    }
}
