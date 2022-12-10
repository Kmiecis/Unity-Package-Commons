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

        public static void SetValue(this SerializedProperty self, object value)
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
                case SerializedPropertyType.Color:
                    self.colorValue = (Color)value;
                    break;
                case SerializedPropertyType.ExposedReference:
                    self.exposedReferenceValue = (Object)value;
                    break;
                case SerializedPropertyType.Float:
                    self.floatValue = (float)value;
                    break;
                case SerializedPropertyType.Integer:
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
            }

            var targetName = self.serializedObject.targetObject.GetType().Name;
            var propertyName = self.name;
            var error = $"Failed to get serialized value of {targetName}.{propertyName}";
            throw new System.Exception(error);
        }

        public static object GetValue(this SerializedProperty self)
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
                case SerializedPropertyType.Color:
                    return self.colorValue;
                case SerializedPropertyType.ExposedReference:
                    return self.exposedReferenceValue;
                case SerializedPropertyType.Float:
                    return self.floatValue;
                case SerializedPropertyType.Integer:
                    return self.intValue;
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

            var targetName = self.serializedObject.targetObject.GetType().Name;
            var propertyName = self.name;
            var error = $"Failed to get serialized value of {targetName}.{propertyName}";
            throw new System.Exception(error);
        }
    }
}
