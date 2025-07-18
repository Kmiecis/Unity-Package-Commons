using Common;
using System;
using System.Collections.Generic;
using UnityEditor;

namespace CommonEditor
{
    public static class SerializedObjectExtensions
    {
        public static SerializedProperty FindPropertyField(this SerializedObject self, string name)
        {
            return self.FindProperty($"<{name}>k__BackingField");
        }

        public static IEnumerable<SerializedProperty> GetChildren(this SerializedObject self)
        {
            var iterator = self.GetIterator();
            if (iterator.NextVisible(true))
            {
                while (iterator.NextVisible(false))
                {
                    yield return iterator;
                }
            }
        }

        public static Type GetTargetType(this SerializedObject self)
        {
            if (self.isEditingMultipleObjects)
            {
                var single = self.targetObjects[0];
                return single.GetType();
            }
            return self.targetObject.GetType();
        }

        public static void SetFieldValue(this SerializedObject self, SerializedProperty property)
        {
            var field = self.targetObject.GetType().GetField(property.name, UBinding.AnyInstance);
            field.SetValue(self.targetObject, property.GetTypeValue());
        }
    }
}