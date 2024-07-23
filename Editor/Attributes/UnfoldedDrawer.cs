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
            if (attribute.labeled)
                UEditorGUI.UnfoldedLabelField(ref position, label);

            UEditorGUI.UnfoldedPropertyField(ref position, property);
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var attribute = (UnfoldedAttribute)this.attribute;
            if (!attribute.labeled)
                return UEditorGUI.GetUnfoldedPropertyHeight(property);

            return (
                UEditorGUI.GetUnfoldedLabelHeight(label) +
                UEditorGUI.GetUnfoldedPropertyHeight(property)
            );
        }
    }
}