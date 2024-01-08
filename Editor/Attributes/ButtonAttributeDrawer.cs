using Common;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(ButtonAttribute))]
    public class ButtonAttributeDrawer : PropertyDrawer
    {
        private const BindingFlags BINDING_FLAGS =
            BindingFlags.Instance |
            BindingFlags.Static |
            BindingFlags.Public |
            BindingFlags.NonPublic;

        private const float PROPERTY_SPACE = 2.0f;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var attribute = (ButtonAttribute)this.attribute;
            var propertyHeight = position.height - EditorGUIUtility.singleLineHeight;

            position.height -= propertyHeight;
            EditorGUI.PropertyField(position, property, label, true);

            position.y += propertyHeight;
            if (GUI.Button(position, attribute.name))
            {
                var target = property.serializedObject.targetObject;
                var type = target.GetType();

                var method = type.GetMethod(attribute.callback, BINDING_FLAGS);
                if (method != null)
                {
                    method.Invoke(target, null);
                }
                else
                {
                    Debug.LogWarning($"{nameof(ButtonAttribute)}: Unable to find method '{attribute.callback}' in '{type.Name}'");
                }
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, true) + EditorGUIUtility.singleLineHeight + PROPERTY_SPACE;
        }
    }
}
