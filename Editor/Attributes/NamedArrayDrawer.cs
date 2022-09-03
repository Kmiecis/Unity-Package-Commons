using Common;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(NamedArrayAttribute))]
    public class NamedArrayDrawer : PropertyDrawer
    {
        private NamedArrayAttribute Attribute
        {
            get => (NamedArrayAttribute)attribute;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (
                int.TryParse(property.propertyPath.Split('[', ']')[1], out int index) &&
                index < Attribute.names.Length
            )
            {
                label = new GUIContent(Attribute.names[index]);
            }
            EditorGUI.PropertyField(position, property, label);
        }
    }
}
