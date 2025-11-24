using Common;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(OnValueChangedAttribute))]
    public class OnValueChangedDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginChangeCheck();
            
            EditorGUI.PropertyField(position, property, label, true);

            if (EditorGUI.EndChangeCheck())
            {
                property.serializedObject.ApplyModifiedProperties();

                CallbackAttempt(property);
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, true);
        }

        private void CallbackAttempt(SerializedProperty property)
        {
            var attribute = (OnValueChangedAttribute)this.attribute;
            var field = fieldInfo.Name.Extract('<', '>');
            var callback = attribute.callback ?? $"On{field}Changed";

            var values = property.GetValueChain().ToArray();
            var value = values[^1];
            var parent = values[^2];

            var method = parent.GetType().GetMethod(callback, UBinding.AnyInstance | BindingFlags.IgnoreCase);
            if (method == null)
            {
                Debug.LogWarning($"{nameof(OnValueChangedAttribute)}: Unable to find method '{callback}' in '{parent.GetType().Name}'");
                return;
            }

            if (!method.HasMatchingParameters(value.GetType()))
            {
                Debug.LogWarning($"{nameof(OnValueChangedAttribute)}: Unable to match parameters of method '{callback}' in '{parent.GetType().Name}'");
                return;
            }

            method.Invoke(parent, value);
        }
    }
}
