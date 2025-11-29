using Common;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(FooterButtonAttribute))]
    public class FooterButtonDrawer : ResizeablePropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            MarkHeightBegin(position.y);

            UEditorGUI.LabelField(ref position, label);
            UEditorGUI.PropertyField(ref position, property, true);

            Button(ref position, property);

            MarkHeightEnd(position.y);
        }

        private void Button(ref Rect position, SerializedProperty property)
        {
            var attribute = (FooterButtonAttribute)this.attribute;
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