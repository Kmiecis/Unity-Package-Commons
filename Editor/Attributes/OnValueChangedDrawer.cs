using Common;
using CommonEditor.Extensions;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(OnValueChangedAttribute))]
    public class OnValueChangedDrawer : BasePropertyDrawer
    {
        private static readonly BindingFlags BINDING_FLAGS =
            BindingFlags.Instance |
            BindingFlags.Static |
            BindingFlags.Public |
            BindingFlags.NonPublic
        ;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var attribute = (OnValueChangedAttribute)this.attribute;
            
            EditorGUI.PropertyField(position, property, label, true);

            if (property.serializedObject.ApplyModifiedProperties())
            {
                var target = property.GetTarget();
                var method = target.GetType()
                    .GetMethod(attribute.callback, BINDING_FLAGS);
                if (method != null)
                {
                    method.Invoke(target, this.GetValue(property));
                }
            }
        }
    }
}
