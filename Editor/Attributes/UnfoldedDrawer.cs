using Common;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(UnfoldedAttribute))]
    public class UnfoldedDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var attribute = (UnfoldedAttribute)this.attribute;
            if (property.hasChildren)
            {
                if (attribute.labeled)
                {
                    UEditorGUI.UnfoldedLabelField(ref position, label);
                }
                UEditorGUI.UnfoldedPropertyField(ref position, property);
            }
            else
            {
                if (!attribute.labeled)
                {
                    label = GUIContent.none;
                }
                EditorGUI.PropertyField(position, property, label);
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var attribute = (UnfoldedAttribute)this.attribute;
            if (property.hasChildren)
            {
                var result = UEditorGUI.GetUnfoldedPropertyHeight(property);
                if (attribute.labeled)
                {
                    result += UEditorGUI.GetUnfoldedLabelHeight(label);
                }
                return result;
            }
            else
            {
                return EditorGUI.GetPropertyHeight(property);
            }
        }
    }
}