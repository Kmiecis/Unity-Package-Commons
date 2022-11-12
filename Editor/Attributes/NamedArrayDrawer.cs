using Common;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(NamedArrayAttribute))]
    public class NamedArrayDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var attribute = (NamedArrayAttribute)this.attribute;

            if (int.TryParse(property.propertyPath.Split('[', ']')[1], out int index) &&
                index < attribute.names.Length)
            {
                label = new GUIContent(attribute.names[index]);
            }

            EditorGUI.PropertyField(position, property, label);
        }
    }
}
