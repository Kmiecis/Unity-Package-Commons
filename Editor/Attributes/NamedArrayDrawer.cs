using Common;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(NamedArrayAttribute))]
    public class NamedArrayDrawer : BasePropertyDrawer<NamedArrayAttribute>
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (int.TryParse(property.propertyPath.Split('[', ']')[1], out int index) &&
                index < attribute.names.Length)
            {
                label = new GUIContent(attribute.names[index]);
            }

            base.OnGUI(position, property, label);
        }
    }
}
