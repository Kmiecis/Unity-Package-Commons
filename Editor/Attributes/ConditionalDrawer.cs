using Common;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(ConditionalAttribute))]
    public class ConditionalDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (CheckCondition(property))
            {
                EditorGUI.PropertyField(position, property, label, true);
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            if (CheckCondition(property))
            {
                return EditorGUI.GetPropertyHeight(property, label, true);
            }
            return 0.0f;
        }

        private bool CheckCondition(SerializedProperty property)
        {
            var attribute = (ConditionalAttribute)this.attribute;
            var field = fieldInfo.Name.Extract('<', '>');
            var conditional = attribute.conditional ?? $"Display{field}Field";

            var values = property.GetValueChain().ToArray();
            var parent = values[^2];

            var method = parent.GetType().FindMethod(conditional, UBinding.AnyInstance | BindingFlags.IgnoreCase);
            if (method == null)
            {
                Debug.LogWarning($"{nameof(ConditionalAttribute)}: Unable to find method '{conditional}' in '{parent.GetType().Name}'");
                return true;
            }

            if (method.ReturnType != typeof(bool))
            {
                Debug.LogWarning($"{nameof(ConditionalAttribute)}: Return type of method '{conditional}' should be of 'bool' in '{parent.GetType().Name}'");
                return true;
            }

            return (bool)method.Invoke(parent);
        }
    }
}