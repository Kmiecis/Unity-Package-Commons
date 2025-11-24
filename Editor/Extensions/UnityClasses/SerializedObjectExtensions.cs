using Common;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;

namespace CommonEditor
{
    public static class SerializedObjectExtensions
    {
        private static readonly FieldInfo NativeObjectPtrField;

        static SerializedObjectExtensions()
        {
            NativeObjectPtrField = ReflectNativeObjectPtrField();
        }

        public static bool IsValid(this SerializedObject self)
        {
            var pointer = (IntPtr)NativeObjectPtrField.GetValue(self);
            return pointer != (IntPtr)0;
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

        private static FieldInfo ReflectNativeObjectPtrField()
        {
            return typeof(SerializedObject).GetField("m_NativeObjectPtr", UBinding.NonPublicInstance);
        }
    }
}