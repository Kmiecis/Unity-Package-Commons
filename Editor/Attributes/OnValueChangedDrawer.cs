using Common;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(OnValueChangedAttribute))]
    public class OnValueChangedDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var attribute = (OnValueChangedAttribute)this.attribute;

            EditorGUI.BeginChangeCheck();
            
            EditorGUI.PropertyField(position, property, label, true);

            if (EditorGUI.EndChangeCheck())
            {
                var target = property.GetTargetObject();
                var targetType = property.GetTargetType();
                var method = targetType.GetMethod(attribute.callback, UBinding.Anything);

                if (method != null)
                {
                    var value = this.GetValue(property);

                    if (method.HasMatchingParameters(value.GetType()))
                    {
                        method.Invoke(target, value);
                    }
                    else
                    {
                        Debug.LogWarning($"{nameof(OnValueChangedAttribute)}: Unable to match parameters of method '{attribute.callback}' and field '{fieldInfo.Name}'");
                    }
                }
                else
                {
                    Debug.LogWarning($"{nameof(OnValueChangedAttribute)}: Unable to find method '{attribute.callback}' in '{targetType.Name}'");
                }
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, true);
        }
    }
}
