using Common;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(AssetReference))]
    public class AssetReferenceDrawer : PropertyDrawer
    {
        private const string OBJECT_PROPERTY_NAME = "_value";

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position = EditorGUI.PrefixLabel(position, label);

            var assetProperty = property.FindPropertyRelative(OBJECT_PROPERTY_NAME);
            EditorGUI.PropertyField(position, assetProperty, GUIContent.none);
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, false);
        }
    }
}