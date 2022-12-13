using Common;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(ObjectReference))]
    public class ObjectReferenceDrawer : PropertyDrawer
    {
        private const string OBJECT_PROPERTY_NAME = "_value";

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position = EditorGUI.PrefixLabel(position, label);

            var sceneProperty = property.FindPropertyRelative(OBJECT_PROPERTY_NAME);
            EditorGUI.PropertyField(position, sceneProperty, GUIContent.none);
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, false);
        }
    }
}