using Common;
using Common.Mathematics;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(ScrollableAttribute))]
    public class ScrollableDrawer : BasePropertyDrawer<ScrollableAttribute>
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            base.OnGUI(position, property, label);

            var current = Event.current;
            if (position.Contains(current.mousePosition) &&
                current.type == EventType.ScrollWheel)
            {
                var change = Mathf.Sign(-current.delta.y) * attribute.delta;

                AdjustValue(property, change);

                current.Use();
            }
        }

        private void AdjustValue(SerializedProperty property, float delta)
        {
            switch (property.propertyType)
            {
                case SerializedPropertyType.Float:
                    property.floatValue = Mathx.RoundTo(property.floatValue + delta, delta);
                    break;

                case SerializedPropertyType.Integer:
                    property.intValue = property.intValue + Mathf.RoundToInt(delta);
                    break;

                default:
                    Debug.LogWarning(this.Format("Requires float or int type field"));
                    break;
            }
        }
    }
}
