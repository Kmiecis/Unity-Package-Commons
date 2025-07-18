using Common;
using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(ChoiceAttribute))]
    public class ChoiceDrawer : PropertyDrawer
    {
        const float SPACING = 2.0f;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var attribute = (ChoiceAttribute)this.attribute;

            EditorGUI.LabelField(position, label);

            var currentValue = this.GetValue(property);
            int currentIndex = Array.IndexOf(attribute.options, currentValue);
            int selectedIndex = EditorGUI.Popup(
                position
                    .WithX(position.x + EditorGUIUtility.labelWidth + SPACING)
                    .WithWidth(position.width - EditorGUIUtility.labelWidth - SPACING),
                currentIndex,
                attribute.options.Select(v => v.ToString()).ToArray()
            );

            if (selectedIndex != currentIndex)
            {
                this.SetValue(property, attribute.options[selectedIndex]);
            }
        }
    }
}
