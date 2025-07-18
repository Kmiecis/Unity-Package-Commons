using Common;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace CommonEditor
{
    public static class SerializedPropertyExtensions
    {
        public static Object GetTargetObject(this SerializedProperty self)
        {
            return self.serializedObject.targetObject;
        }

        public static Type GetTargetType(this SerializedProperty self)
        {
            return self.serializedObject.GetTargetType();
        }

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

        public static object GetTypeValue(this SerializedProperty self)
        {
            switch (self.propertyType)
            {
                case SerializedPropertyType.AnimationCurve:
                    return self.animationCurveValue;
                case SerializedPropertyType.ArraySize:
                    return self.arraySize;
                case SerializedPropertyType.Boolean:
                    return self.boolValue;
                case SerializedPropertyType.Bounds:
                    return self.boundsValue;
                case SerializedPropertyType.BoundsInt:
                    return self.boundsIntValue;
                case SerializedPropertyType.Character:
                    return self.intValue;
                case SerializedPropertyType.Color:
                    return self.colorValue;
                case SerializedPropertyType.Enum:
                    return self.intValue;
                case SerializedPropertyType.ExposedReference:
                    return self.exposedReferenceValue;
                case SerializedPropertyType.FixedBufferSize:
                    return self.intValue;
                case SerializedPropertyType.Float:
                    return self.floatValue;
                case SerializedPropertyType.Hash128:
                    return self.hash128Value;
                case SerializedPropertyType.Integer:
                    return self.intValue;
                case SerializedPropertyType.LayerMask:
                    return self.intValue;
                case SerializedPropertyType.ManagedReference:
                    return self.managedReferenceValue;
                case SerializedPropertyType.ObjectReference:
                    return self.objectReferenceValue;
                case SerializedPropertyType.Quaternion:
                    return self.quaternionValue;
                case SerializedPropertyType.Rect:
                    return self.rectValue;
                case SerializedPropertyType.RectInt:
                    return self.rectIntValue;
                case SerializedPropertyType.String:
                    return self.stringValue;
                case SerializedPropertyType.Vector2:
                    return self.vector2Value;
                case SerializedPropertyType.Vector2Int:
                    return self.vector2IntValue;
                case SerializedPropertyType.Vector3:
                    return self.vector3Value;
                case SerializedPropertyType.Vector3Int:
                    return self.vector3IntValue;
                case SerializedPropertyType.Vector4:
                    return self.vector4Value;
            }
            return self.GetValue();
        }

        public static void SetTypeValue(this SerializedProperty self, object value)
        {
            switch (self.propertyType)
            {
                case SerializedPropertyType.AnimationCurve:
                    self.animationCurveValue = (AnimationCurve)value;
                    break;
                case SerializedPropertyType.ArraySize:
                    self.arraySize = (int)value;
                    break;
                case SerializedPropertyType.Boolean:
                    self.boolValue = (bool)value;
                    break;
                case SerializedPropertyType.Bounds:
                    self.boundsValue = (Bounds)value;
                    break;
                case SerializedPropertyType.BoundsInt:
                    self.boundsIntValue = (BoundsInt)value;
                    break;
                case SerializedPropertyType.Character:
                    self.intValue = (int)value;
                    break;
                case SerializedPropertyType.Color:
                    self.colorValue = (Color)value;
                    break;
                case SerializedPropertyType.Enum:
                    self.intValue = (int)value;
                    break;
                case SerializedPropertyType.ExposedReference:
                    self.exposedReferenceValue = (Object)value;
                    break;
                case SerializedPropertyType.FixedBufferSize:
                    self.intValue = (int)value;
                    break;
                case SerializedPropertyType.Float:
                    self.floatValue = (float)value;
                    break;
                case SerializedPropertyType.Hash128:
                    self.hash128Value = (Hash128)value;
                    break;
                case SerializedPropertyType.Integer:
                    self.intValue = (int)value;
                    break;
                case SerializedPropertyType.LayerMask:
                    self.intValue = (int)value;
                    break;
                case SerializedPropertyType.ManagedReference:
                    self.managedReferenceValue = value;
                    break;
                case SerializedPropertyType.ObjectReference:
                    self.objectReferenceValue = (Object)value;
                    break;
                case SerializedPropertyType.Quaternion:
                    self.quaternionValue = (Quaternion)value;
                    break;
                case SerializedPropertyType.Rect:
                    self.rectValue = (Rect)value;
                    break;
                case SerializedPropertyType.RectInt:
                    self.rectIntValue = (RectInt)value;
                    break;
                case SerializedPropertyType.String:
                    self.stringValue = (string)value;
                    break;
                case SerializedPropertyType.Vector2:
                    self.vector2Value = (Vector2)value;
                    break;
                case SerializedPropertyType.Vector2Int:
                    self.vector2IntValue = (Vector2Int)value;
                    break;
                case SerializedPropertyType.Vector3:
                    self.vector3Value = (Vector3)value;
                    break;
                case SerializedPropertyType.Vector3Int:
                    self.vector3IntValue = (Vector3Int)value;
                    break;
                case SerializedPropertyType.Vector4:
                    self.vector4Value = (Vector4)value;
                    break;
                default:
                    self.SetValue(value);
                    break;
            }
        }

        public static object GetValue(this SerializedProperty self)
        {
            var sanitizedPath = self.propertyPath.Replace(".Array.data[", "[");
            object result = self.GetTargetObject();

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
            object target = self.GetTargetObject();

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
