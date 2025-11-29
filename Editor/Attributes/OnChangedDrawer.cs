using Common;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(OnChangedAttribute))]
    public class OnChangedDrawer : BasePropertyDrawer<OnChangedAttribute>
    {
        private static Dictionary<string, object> _values;

        static OnChangedDrawer()
        {
            _values = new Dictionary<string, object>();
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            base.OnGUI(position, property, label);

            if (UpdateCachedValue(property))
            {
                CallbackAttempt(property);
            }
        }

        private void CallbackAttempt(SerializedProperty property)
        {
            var callback = attribute.callback ?? GetFallback(fieldInfo);

            var values = property.GetValueChain().ToArray();
            var value = values[^1];
            var parent = values[^2];

            if (TryGetMethod(value, parent, callback, out var method))
            {
                method.Invoke(parent, value);
            }
        }

        private static string GetFallback(FieldInfo fieldInfo)
        {
            var fieldName = fieldInfo.GetRealName();
            return $"On{fieldName}Changed";
        }

        private static bool TryGetMethod(object value, object parent, string callback, out MethodInfo method)
        {
            var valueType = value.GetType();
            var parentType = parent.GetType();

            method = parentType.GetMethod(callback, UBinding.AnyInstance | BindingFlags.IgnoreCase);
            if (method == null)
            {
                Debug.LogWarning($"{nameof(OnChangedDrawer)}: Unable to find method '{callback}' in '{parentType.Name}'");
                return false;
            }

            if (!method.HasMatchingParameters(valueType))
            {
                Debug.LogWarning($"{nameof(OnChangedDrawer)}: Unable to match parameters of method '{callback}({valueType})' in '{parentType.Name}'");
                return false;
            }

            return true;
        }

        protected static bool UpdateCachedValue(SerializedProperty property)
        {
            var key = property.MakeKey();

            var current = property.GetValue();
            if (!_values.TryGetValue(key, out var previous) || !Equals(previous, current))
            {
                _values[key] = current;
                return true;
            }
            return false;
        }
    }
}
