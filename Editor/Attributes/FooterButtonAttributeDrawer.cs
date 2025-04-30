using Common;
using CommonEditor.Extensions;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(FooterButtonAttribute))]
    public class FooterButtonAttributeDrawer : ResizeablePropertyDrawer
    {
        private const BindingFlags BINDING_FLAGS =
            BindingFlags.Instance |
            BindingFlags.Static |
            BindingFlags.Public |
            BindingFlags.NonPublic;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            MarkHeightBegin(position.y);

            UEditorGUI.LabelField(ref position, label);
            UEditorGUI.PropertyField(ref position, property, true);

            Button(ref position, property.GetTargetObject());

            MarkHeightEnd(position.y);
        }

        private void Button(ref Rect position, Object target)
        {
            var attribute = (FooterButtonAttribute)this.attribute;
            if (UGUI.Button(ref position, attribute.name))
            {
                var type = target.GetType();

                var method = type.GetMethod(attribute.callback, BINDING_FLAGS);
                if (method != null)
                {
                    method.Invoke(target, null);
                }
                else
                {
                    Debug.LogWarning($"{nameof(FooterButtonAttribute)}: Unable to find method '{attribute.callback}' in '{type.Name}'");
                }
            }
        }
    }
}