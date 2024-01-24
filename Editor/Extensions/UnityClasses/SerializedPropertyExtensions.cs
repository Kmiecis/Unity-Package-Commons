using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace CommonEditor.Extensions
{
    public static class SerializedPropertyExtensions
    {
        public static int CountChildren(this SerializedProperty self)
        {
            self = self.Copy();

            int result = 0;
            foreach (var child in self)
                result++;
            return result;
        }

        public static Object GetTarget(this SerializedProperty self)
        {
            return self.serializedObject.targetObject;
        }

        public static Object[] GetTargets(this SerializedProperty self)
        {
            return self.serializedObject.targetObjects;
        }

        public static System.Type GetValueType(this SerializedProperty self)
        {
            switch (self.propertyType)
            {
                case SerializedPropertyType.AnimationCurve:
                    return typeof(AnimationCurve);
                case SerializedPropertyType.ArraySize:
                    return typeof(int);
                case SerializedPropertyType.Boolean:
                    return typeof(bool);
                case SerializedPropertyType.Bounds:
                    return typeof(Bounds);
                case SerializedPropertyType.BoundsInt:
                    return typeof(BoundsInt);
                case SerializedPropertyType.Character:
                    return typeof(char);
                case SerializedPropertyType.Color:
                    return typeof(Color);
                case SerializedPropertyType.Enum:
                    break;
                case SerializedPropertyType.ExposedReference:
                    break;
                case SerializedPropertyType.FixedBufferSize:
                    return typeof(int);
                case SerializedPropertyType.Float:
                    return typeof(float);
                case SerializedPropertyType.Hash128:
                    return typeof(Hash128);
                case SerializedPropertyType.Integer:
                    return typeof(int);
                case SerializedPropertyType.LayerMask:
                    return typeof(LayerMask);
                case SerializedPropertyType.ManagedReference:
                    break;
                case SerializedPropertyType.ObjectReference:
                    break;
                case SerializedPropertyType.Quaternion:
                    return typeof(Quaternion);
                case SerializedPropertyType.Rect:
                    return typeof(Rect);
                case SerializedPropertyType.RectInt:
                    return typeof(RectInt);
                case SerializedPropertyType.String:
                    return typeof(string);
                case SerializedPropertyType.Vector2:
                    return typeof(Vector2);
                case SerializedPropertyType.Vector2Int:
                    return typeof(Vector2Int);
                case SerializedPropertyType.Vector3:
                    return typeof(Vector3);
                case SerializedPropertyType.Vector3Int:
                    return typeof(Vector3Int);
                case SerializedPropertyType.Vector4:
                    return typeof(Vector4);
            }

            return typeof(object);
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
                    goto case SerializedPropertyType.Integer;
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

            throw new System.NotSupportedException(string.Format("The GetValue method failed on \"{0}\" because it has an unsupported propertyType {1}.", self.propertyPath, self.propertyType));
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
                    goto case SerializedPropertyType.Integer;
                case SerializedPropertyType.Color:
                    self.colorValue = (Color)value;
                    break;
                case SerializedPropertyType.Enum:
                    goto case SerializedPropertyType.Integer;
                case SerializedPropertyType.ExposedReference:
                    self.exposedReferenceValue = (Object)value;
                    break;
                case SerializedPropertyType.FixedBufferSize:
                    goto case SerializedPropertyType.Integer;
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
                    goto case SerializedPropertyType.Integer;
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
            }

            throw new System.NotSupportedException(string.Format("The SetValue method failed on \"{0}\" because it has an unsupported propertyType {1}.", self.propertyPath, self.propertyType));
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
                    var elementName = element.Substring(0, element.IndexOf("["));
                    var strIndex = element.Substring(element.IndexOf("[")).Replace("[", string.Empty).Replace("]", string.Empty);
                    var index = int.Parse(strIndex);
                    result = GetValueFromList(result, elementName, index);
                }
                else
                {
                    result = GetValueFromType(result, element);
                }
            }
            return result;
        }

        private static object GetValueFromList(object source, string name, int index)
        {
            var list = GetValueFromType(source, name) as System.Collections.IList;
            if (list != null)
            {
                return list[index];
            }
            return null;
        }

        private static object GetValueFromType(object source, string name)
        {
            var type = source.GetType();
            while (type != null)
            {
                var field = type.GetField(name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                if (field != null)
                {
                    return field.GetValue(source);
                }

                var property = type.GetProperty(name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (property != null)
                {
                    return property.GetValue(source, null);
                }

                type = type.BaseType;
            }
            return null;
        }
    }
}
