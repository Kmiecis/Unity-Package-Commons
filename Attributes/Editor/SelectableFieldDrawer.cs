#if UNITY_EDITOR
using Common;
using Common.Extensions;
using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(SelectableFieldAttribute))]
    public class SelectableFieldDrawer : PropertyDrawer
    {
        const float SPACING = 2.0f;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var attribute = (SelectableFieldAttribute)this.attribute;

            EditorGUI.LabelField(position.CopyAndSet(width: EditorGUIUtility.labelWidth), label);
            var currentValue = property.GetValue();
            int currentIndex = Array.IndexOf(attribute.values, currentValue);
            int selectedIndex = EditorGUI.Popup(
                position.CopyAndSet(x: position.x + EditorGUIUtility.labelWidth + SPACING, width: position.width - EditorGUIUtility.labelWidth - SPACING),
                currentIndex,
                attribute.values.Select(v => v.ToString()).ToArray()
            );
            if (selectedIndex != currentIndex)
            {
                property.SetValue(attribute.values[selectedIndex]);
            }
        }
    }
}
#endif