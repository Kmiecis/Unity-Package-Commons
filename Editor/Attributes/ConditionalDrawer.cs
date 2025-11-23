using Common;
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
            var target = property.serializedObject.targetObject;
            var method = target.GetType().FindMethod(attribute.conditional, UBinding.AnyInstance);
            return (bool)method.Invoke(target);
        }
    }
}