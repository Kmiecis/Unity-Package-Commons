#if UNITY_EDITOR
using Common;
using Common.Extensions;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(ShiftFieldAttribute))]
    public class ShiftFieldDrawer : PropertyDrawer
    {
        const float ARROW_WIDTH = 20.0f;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.propertyType == SerializedPropertyType.Integer)
            {
                EditorGUI.PropertyField(position.CopyAndSet(width: position.width - 2 * ARROW_WIDTH), property);
                if (GUI.Button(position.CopyAndSet(x: position.x + position.width - 2 * ARROW_WIDTH, width: ARROW_WIDTH), "<"))
                    property.intValue = ShiftLeft(property.intValue);
                if (GUI.Button(position.CopyAndSet(x: position.x + position.width - ARROW_WIDTH, width: ARROW_WIDTH), ">"))
                    property.intValue = ShiftRight(property.intValue);
            }
            else
            {
                EditorGUI.LabelField(position, label.text, "Use ShiftField with int.");
            }
        }
        
        private static int ShiftLeft(int v)
        {
            if (v > 0)
                return v >> 1;
            else if (v < 0)
                return v << 1;
            return -1;
        }
        
        private static int ShiftRight(int v)
        {
            if (v > 0)
                return v << 1;
            else if (v < 0)
                return v >> 1;
            return 1;
        }
    }
}
#endif