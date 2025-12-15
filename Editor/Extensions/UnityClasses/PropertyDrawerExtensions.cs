using UnityEditor;

namespace CommonEditor
{
    public static class PropertyDrawerExtensions
    {
        public static object GetValue(this PropertyDrawer self, SerializedProperty property)
        {
            return self.fieldInfo.GetValue(property.GetTargetObject());
        }

        public static void SetValue(this PropertyDrawer self, SerializedProperty property, object value)
        {
            self.fieldInfo.SetValue(property.GetTargetObject(), value);
        }

        public static string Format(this PropertyDrawer self, string message)
        {
            return $"{self.attribute.ToString()} ({self.fieldInfo.Name}): {message}";
        }
    }
}
