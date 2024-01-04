using Common;
using Common.Extensions;
using CommonEditor.Extensions;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(OnValueChangedAttribute))]
    public class OnValueChangedDrawer : PropertyDrawer
    {
        private const BindingFlags BINDING_FLAGS =
            BindingFlags.Instance |
            BindingFlags.Static |
            BindingFlags.Public |
            BindingFlags.NonPublic;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var attribute = (OnValueChangedAttribute)this.attribute;
            
            EditorGUI.PropertyField(position, property, label, true);

            if (property.serializedObject.ApplyModifiedProperties())
            {
                var target = property.GetTarget();
                var type = target.GetType();
                var method = type.GetMethod(attribute.callback, BINDING_FLAGS);

                if (method != null)
                {
                    method.Invoke(target, this.GetValue(property));
                }
                else
                {
                    Debug.LogWarning($"{nameof(OnValueChangedAttribute)}: Unable to find method {attribute.callback} in {type}");
                }
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, true);
        }
    }
}
