using Common;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(RuntimeFieldAttribute))]
    public class RuntimeFieldDrawer : BasePropertyDrawer<RuntimeFieldAttribute>
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (Application.isPlaying)
            {
                base.OnGUI(position, property, label);
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            if (Application.isPlaying)
            {
                return base.GetPropertyHeight(property, label);
            }
            return 0.0f;
        }
    }
}