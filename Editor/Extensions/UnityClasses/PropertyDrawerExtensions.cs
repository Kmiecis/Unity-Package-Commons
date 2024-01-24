using UnityEditor;

namespace CommonEditor.Extensions
{
    public static class PropertyDrawerExtensions
    {
        public static object GetValue(this PropertyDrawer self, SerializedProperty property)
        {
            return self.fieldInfo.GetValue(property.serializedObject.targetObject);
        }

        public static void SetValue(this PropertyDrawer self, SerializedProperty property, object value)
        {
            self.fieldInfo.SetValue(property.serializedObject.targetObject, value);
        }
    }
}
