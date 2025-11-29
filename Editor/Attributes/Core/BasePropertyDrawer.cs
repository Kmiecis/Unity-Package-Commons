using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public class BasePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.PropertyField(position, property, label, true);
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, true);
        }
    }

    public class BasePropertyDrawer<T> : BasePropertyDrawer
        where T : PropertyAttribute
    {
        public new T attribute
            => (T)base.attribute;
    }
}