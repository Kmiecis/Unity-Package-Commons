using Common;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;

namespace CommonEditor.Extensions
{
    public static class SerializedPropertyExtensions
    {
        public static bool IsInArray(this SerializedProperty self)
        {
            return self.propertyPath.EndsWith("]");
        }

        public static SerializedProperty FindPropertyRelativeField(this SerializedProperty self, string name)
        {
            return self.FindPropertyRelative($"<{name}>k__BackingField");
        }

        public static IEnumerable<SerializedProperty> GetChildren(this SerializedProperty self)
        {
            var iterator = self.Copy();
            var end = iterator.GetEndProperty();

            if (iterator.NextVisible(true))
            {
                do
                {
                    if (SerializedProperty.EqualContents(iterator, end))
                    {
                        break;
                    }
                    yield return iterator;
                }
                while (iterator.NextVisible(false));
            }
        }

        public static int CountChildren(this SerializedProperty self)
        {
            int result = 0;
            foreach (var child in self.GetChildren())
            {
                result++;
            }
            return result;
        }

        public static IEnumerable<SerializedProperty> GetArrayElements(this SerializedProperty self)
        {
            int count = self.arraySize;
            for (int i = 0; i < count; ++i)
            {
                yield return self.GetArrayElementAtIndex(i);
            }
        }

        public static SerializedProperty AddArrayElement(this SerializedProperty self)
        {
            int index = self.arraySize;
            self.InsertArrayElementAtIndex(index);
            return self.GetArrayElementAtIndex(index);
        }

        public static SerializedProperty GetLastArrayElement(this SerializedProperty self)
        {
            int index = self.arraySize - 1;
            return self.GetArrayElementAtIndex(index);
        }

        public static void DeleteLastArrayElement(this SerializedProperty self)
        {
            int index = self.arraySize - 1;
            self.DeleteArrayElementAtIndex(index);
        }

        public static object GetValue(this SerializedProperty self)
        {
            var sanitizedPath = self.propertyPath.Replace(".Array.data[", "[");
            object result = self.serializedObject.targetObject;

            var elements = sanitizedPath.Split('.');
            foreach (var element in elements)
            {
                if (element.Contains("["))
                {
                    result = GetValueFromList(result, element);
                }
                else
                {
                    result = GetValueFromType(result, element);
                }
            }
            return result;
        }

        public static void SetValue(this SerializedProperty self, object value)
        {
            var sanitizedPath = self.propertyPath.Replace(".Array.data[", "[");
            object target = self.serializedObject.targetObject;

            var element = (string)null;
            var elements = sanitizedPath.Split('.');
            for (int i = 0; i < elements.Length - 1; ++i)
            {
                element = elements[i];
                if (element.Contains("["))
                {
                    target = GetValueFromList(target, element);
                }
                else
                {
                    target = GetValueFromType(target, element);
                }
            }

            element = elements[elements.Length - 1];
            if (element.Contains("["))
            {
                SetValueToList(target, element, value);
            }
            else
            {
                SetValueToType(target, element, value);
            }
        }

        private static object GetValueFromList(object source, string subpath)
        {
            var indexBegin = subpath.IndexOf("[");
            var indexEnd = subpath.IndexOf("]");
            var strIndex = subpath.Substring(indexBegin + 1, indexEnd - (indexBegin + 1));
            var index = int.Parse(strIndex);

            var name = subpath.Substring(0, indexBegin);

            var list = GetValueFromType(source, name) as System.Collections.IList;
            if (list != null)
            {
                return list[index];
            }
            return null;
        }

        private static void SetValueToList(object target, string subpath, object value)
        {
            var indexBegin = subpath.IndexOf("[");
            var indexEnd = subpath.IndexOf("]");
            var strIndex = subpath.Substring(indexBegin + 1, indexEnd - (indexBegin + 1));
            var index = int.Parse(strIndex);

            var name = subpath.Substring(0, indexBegin);

            var list = GetValueFromType(target, name) as System.Collections.IList;
            if (list != null)
            {
                list[index] = value;
            }
        }

        private static object GetValueFromType(object source, string name)
        {
            var type = source.GetType();
            while (type != null)
            {
                var fieldFlags = UBinding.AnyInstance;
                var field = type.GetField(name, fieldFlags);
                if (field != null)
                {
                    return field.GetValue(source);
                }

                var propertyFlags = UBinding.AnyInstance | BindingFlags.IgnoreCase;
                var property = type.GetProperty(name, propertyFlags);
                if (property != null)
                {
                    return property.GetValue(source, null);
                }

                type = type.BaseType;
            }
            return null;
        }

        private static void SetValueToType(object target, string name, object value)
        {
            var type = target.GetType();
            while (type != null)
            {
                var fieldFlags = UBinding.AnyInstance;
                var field = type.GetField(name, fieldFlags);
                if (field != null)
                {
                    field.SetValue(target, value);
                    return;
                }

                var propertyFlags = UBinding.AnyInstance | BindingFlags.IgnoreCase;
                var property = type.GetProperty(name, propertyFlags);
                if (property != null)
                {
                    property.SetValue(target, value);
                    return;
                }

                type = type.BaseType;
            }
        }
    }
}
