using Common;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(HeaderButtonAttribute))]
    public class HeaderButtonDrawer : ResizeablePropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            MarkHeightBegin(position.y);

            Button(ref position, property.GetTargetObject());

            UEditorGUI.LabelField(ref position, label);
            UEditorGUI.PropertyField(ref position, property, true);

            MarkHeightEnd(position.y);
        }

        private void Button(ref Rect position, Object target)
        {
            var attribute = (HeaderButtonAttribute)this.attribute;
            if (UGUI.Button(ref position, attribute.name))
            {
                var type = target.GetType();

                var method = type.GetMethod(attribute.callback, UBinding.Anything);
                if (method != null)
                {
                    method.Invoke(target, null);
                }
                else
                {
                    Debug.LogWarning($"{nameof(HeaderButtonAttribute)}: Unable to find method '{attribute.callback}' in '{type.Name}'");
                }
            }
        }
    }
}