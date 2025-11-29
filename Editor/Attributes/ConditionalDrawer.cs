using Common;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(ConditionalAttribute))]
    public class ConditionalDrawer : BasePropertyDrawer<ConditionalAttribute>
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (CheckCondition(property))
            {
                base.OnGUI(position, property, label);
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            if (CheckCondition(property))
            {
                return base.GetPropertyHeight(property, label);
            }
            return 0.0f;
        }

        private bool CheckCondition(SerializedProperty property)
        {
            var conditional = attribute.conditional ?? $"Display{property.displayName}Field";

            var values = property.GetValueChain().ToArray();
            var parent = values[^2];

            return (
                TryGetMethod(parent, conditional, out var method) &&
                (bool)method.Invoke(parent)
            );
        }

        private static bool TryGetMethod(object parent, string conditional, out MethodInfo method)
        {
            var parentType = parent.GetType();

            method = parentType.FindMethod(conditional, UBinding.AnyInstance | BindingFlags.IgnoreCase);
            if (method == null)
            {
                Debug.LogWarning($"{nameof(ConditionalDrawer)}: Unable to find method '{conditional}' in '{parentType.Name}'");
                return false;
            }

            if (method.ReturnType != typeof(bool))
            {
                Debug.LogWarning($"{nameof(ConditionalDrawer)}: Return type of method '{conditional}' should be of 'bool' in '{parentType.Name}'");
                return false;
            }

            return true;
        }
    }
}