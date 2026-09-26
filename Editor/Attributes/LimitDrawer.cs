using Common;
using UnityEditor;
using UnityEngine;
using RangeInt = Common.RangeInt;

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
            var value = property.GetValue();
            value = value switch
            {
                float floatValue => Clamp(floatValue),
                int intValue => Clamp(intValue),
                Vector2 vector2 => Clamp(vector2),
                Vector2Int vector2Int => Clamp(vector2Int),
                Vector3 vector3 => Clamp(vector3),
                Vector3Int vector3Int => Clamp(vector3Int),
                Vector4 vector4 => Clamp(vector4),
                Range range => Clamp(range),
                RangeInt rangeInt => Clamp(rangeInt),
                Range2 range2 => Clamp(range2),
                Range2Int range2Int => Clamp(range2Int),
                Range3 range3 => Clamp(range3),
                Range3Int range3Int => Clamp(range3Int),
                _ => Clamp(value)
            };
            property.SetValue(value);
        }

        private float Clamp(float value)
        {
            value = Mathf.Clamp(value, attribute.min, attribute.max);
            return value;
        }

        private int Clamp(int value)
        {
            value = (int)Mathf.Clamp(value, attribute.min, attribute.max);
            return value;
        }

        private Vector2 Clamp(Vector2 value)
        {
            value.x = Mathf.Clamp(value.x, attribute.min, attribute.max);
            value.y = Mathf.Clamp(value.y, attribute.min, attribute.max);
            return value;
        }

        private Vector2Int Clamp(Vector2Int value)
        {
            value.x = (int)Mathf.Clamp(value.x, attribute.min, attribute.max);
            value.y = (int)Mathf.Clamp(value.y, attribute.min, attribute.max);
            return value;
        }

        private Vector3 Clamp(Vector3 value)
        {
            value.x = Mathf.Clamp(value.x, attribute.min, attribute.max);
            value.y = Mathf.Clamp(value.y, attribute.min, attribute.max);
            value.z = Mathf.Clamp(value.z, attribute.min, attribute.max);
            return value;
        }

        private Vector3Int Clamp(Vector3Int value)
        {
            value.x = (int)Mathf.Clamp(value.x, attribute.min, attribute.max);
            value.y = (int)Mathf.Clamp(value.y, attribute.min, attribute.max);
            value.z = (int)Mathf.Clamp(value.z, attribute.min, attribute.max);
            return value;
        }

        private Vector4 Clamp(Vector4 value)
        {
            value.x = Mathf.Clamp(value.x, attribute.min, attribute.max);
            value.y = Mathf.Clamp(value.y, attribute.min, attribute.max);
            value.z = Mathf.Clamp(value.z, attribute.min, attribute.max);
            value.w = Mathf.Clamp(value.w, attribute.min, attribute.max);
            return value;
        }

        private Range Clamp(Range value)
        {
            value.min = Mathf.Clamp(value.min, attribute.min, attribute.max);
            value.max = Mathf.Clamp(value.max, attribute.min, attribute.max);
            return value;
        }

        private RangeInt Clamp(RangeInt value)
        {
            value.min = (int)Mathf.Clamp(value.min, attribute.min, attribute.max);
            value.max = (int)Mathf.Clamp(value.max, attribute.min, attribute.max);
            return value;
        }

        private Range2 Clamp(Range2 value)
        {
            value.min.x = Mathf.Clamp(value.min.x, attribute.min, attribute.max);
            value.min.y = Mathf.Clamp(value.min.y, attribute.min, attribute.max);
            value.max.x = Mathf.Clamp(value.max.x, attribute.min, attribute.max);
            value.max.y = Mathf.Clamp(value.max.y, attribute.min, attribute.max);
            return value;
        }

        private Range2Int Clamp(Range2Int value)
        {
            value.min.x = (int)Mathf.Clamp(value.min.x, attribute.min, attribute.max);
            value.min.y = (int)Mathf.Clamp(value.min.y, attribute.min, attribute.max);
            value.max.x = (int)Mathf.Clamp(value.max.x, attribute.min, attribute.max);
            value.max.y = (int)Mathf.Clamp(value.max.y, attribute.min, attribute.max);
            return value;
        }

        private Range3 Clamp(Range3 value)
        {
            value.min.x = Mathf.Clamp(value.min.x, attribute.min, attribute.max);
            value.min.y = Mathf.Clamp(value.min.y, attribute.min, attribute.max);
            value.min.z = Mathf.Clamp(value.min.z, attribute.min, attribute.max);
            value.max.x = Mathf.Clamp(value.max.x, attribute.min, attribute.max);
            value.max.y = Mathf.Clamp(value.max.y, attribute.min, attribute.max);
            value.max.z = Mathf.Clamp(value.max.z, attribute.min, attribute.max);
            return value;
        }

        private Range3Int Clamp(Range3Int value)
        {
            value.min.x = (int)Mathf.Clamp(value.min.x, attribute.min, attribute.max);
            value.min.y = (int)Mathf.Clamp(value.min.y, attribute.min, attribute.max);
            value.min.z = (int)Mathf.Clamp(value.min.z, attribute.min, attribute.max);
            value.max.x = (int)Mathf.Clamp(value.max.x, attribute.min, attribute.max);
            value.max.y = (int)Mathf.Clamp(value.max.y, attribute.min, attribute.max);
            value.max.z = (int)Mathf.Clamp(value.max.z, attribute.min, attribute.max);
            return value;
        }

        private object Clamp(object value)
        {
            Debug.LogWarning("Unsupported type field for " + nameof(LimitAttribute));
            return value;
        }
    }
}
