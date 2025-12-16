using Common;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(FooterButtonAttribute))]
    public class FooterButtonDrawer : BasePropertyDrawer<FooterButtonAttribute>
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            UEditorGUI.PropertyField(ref position, property, label, true);

            Button(ref position, property);
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return (
                base.GetPropertyHeight(property, label) +
                UEditorGUIUtility.LineHeight
            );
        }

        private void Button(ref Rect position, SerializedProperty property)
        {
            if (UGUI.Button(ref position, attribute.name))
            {
                var values = property.GetValueChain().ToArray();
                var parent = values[^2];
                var parentType = parent.GetType();

                var method = parentType.GetMethod(attribute.callback, UBinding.Anything);
                if (method != null)
                {
                    method.Invoke(parent);
                }
                else
                {
                    Debug.LogWarning($"{nameof(FooterButtonAttribute)}: Unable to find method '{attribute.callback}' in '{parentType.Name}'");
                }
            }
        }
    }
}