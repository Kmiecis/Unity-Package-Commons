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
            return Mathf.Clamp(value, attribute.min, attribute.max);
        }

        private int Clamp(int value)
        {
            return Mathf.Clamp(value, (int)attribute.min, (int)attribute.max);
        }

        private Range Clamp(Range value)
        {
            return new Range(
                Mathf.Clamp(value.min, attribute.min, attribute.max),
                Mathf.Clamp(value.max, attribute.min, attribute.max)
            );
        }

        private RangeInt Clamp(RangeInt value)
        {
            return new RangeInt(
                Mathf.Clamp(value.min, (int)attribute.min, (int)attribute.max),
                Mathf.Clamp(value.max, (int)attribute.min, (int)attribute.max)
            );
        }

        private Range2 Clamp(Range2 value)
        {
            return new Range2(
                Mathx.Clamp(value.min, attribute.min, attribute.max),
                Mathx.Clamp(value.max, attribute.min, attribute.max)
            );
        }

        private Range2Int Clamp(Range2Int value)
        {
            return new Range2Int(
                Mathx.Clamp(value.min, (int)attribute.min, (int)attribute.max),
                Mathx.Clamp(value.max, (int)attribute.min, (int)attribute.max)
            );
        }

        private Range3 Clamp(Range3 value)
        {
            return new Range3(
                Mathx.Clamp(value.min, attribute.min, attribute.max),
                Mathx.Clamp(value.max, attribute.min, attribute.max)
            );
        }

        private Range3Int Clamp(Range3Int value)
        {
            return new Range3Int(
                Mathx.Clamp(value.min, (int)attribute.min, (int)attribute.max),
                Mathx.Clamp(value.max, (int)attribute.min, (int)attribute.max)
            );
        }

        private object Clamp(object value)
        {
            Debug.LogWarning("Unsupported type field for " + nameof(LimitAttribute));
            return value;
        }
    }
}
