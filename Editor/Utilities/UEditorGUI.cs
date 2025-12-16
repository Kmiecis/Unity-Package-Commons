using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public static class UEditorGUI
    {
        public static Bounds BoundsField(ref Rect position, Bounds value, GUIContent label = null)
        {
            position.height = EditorGUI.GetPropertyHeight(SerializedPropertyType.Bounds, label);
            var result = EditorGUI.BoundsField(position, label, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static BoundsInt BoundsIntField(ref Rect position, BoundsInt value, GUIContent label = null)
        {
            position.height = EditorGUI.GetPropertyHeight(SerializedPropertyType.BoundsInt, label);
            var result = EditorGUI.BoundsIntField(position, label, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static Color ColorField(ref Rect position, Color value, GUIContent label = null)
        {
            position.height = EditorGUI.GetPropertyHeight(SerializedPropertyType.Color, label);
            var result = EditorGUI.ColorField(position, label, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static AnimationCurve CurveField(ref Rect position, AnimationCurve value, GUIContent label = null)
        {
            position.height = EditorGUI.GetPropertyHeight(SerializedPropertyType.AnimationCurve, label);
            var result = EditorGUI.CurveField(position, label, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static double DoubleField(ref Rect position, double value, GUIContent label = null)
        {
            position.height = EditorGUI.GetPropertyHeight(SerializedPropertyType.Float, label);
            var result = EditorGUI.DoubleField(position, label, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static float FloatField(ref Rect position, float value, GUIContent label = null)
        {
            position.height = EditorGUI.GetPropertyHeight(SerializedPropertyType.Float, label);
            var result = EditorGUI.FloatField(position, label, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static Gradient GradientField(ref Rect position, Gradient value, GUIContent label = null)
        {
            position.height = EditorGUI.GetPropertyHeight(SerializedPropertyType.Gradient, label);
            var result = EditorGUI.GradientField(position, label, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static void HeaderField(ref Rect position, GUIContent label)
        {
            position.height = EditorGUIUtility.singleLineHeight;
            EditorGUI.LabelField(position, label);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
        }

        public static int IntField(ref Rect position, int value, GUIContent label = null)
        {
            position.height = EditorGUI.GetPropertyHeight(SerializedPropertyType.Integer, label);
            var result = EditorGUI.IntField(position, label, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static void LabelField(ref Rect position, GUIContent label)
        {
            position.height = EditorGUIUtility.singleLineHeight;
            EditorGUI.LabelField(position, label);
        }

        public static int LayerField(ref Rect position, int value, GUIContent label = null)
        {
            position.height = EditorGUI.GetPropertyHeight(SerializedPropertyType.LayerMask, label);
            var result = EditorGUI.LayerField(position, label, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static int MaskField(ref Rect position, int value, string[] options, GUIContent label = null)
        {
            position.height = EditorGUI.GetPropertyHeight(SerializedPropertyType.LayerMask, label);
            var result = EditorGUI.MaskField(position, label, value, options);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static void ObjectField(ref Rect position, Object value, System.Type type, bool allowSceneObjects, GUIContent label = null)
        {
            position.height = EditorGUI.GetPropertyHeight(SerializedPropertyType.ObjectReference, label);
            var result = EditorGUI.ObjectField(position, label, value, type, allowSceneObjects);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
        }

        public static bool PropertyField(ref Rect position, SerializedProperty property)
        {
            position.height = EditorGUI.GetPropertyHeight(property);
            var result = EditorGUI.PropertyField(position, property);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static bool PropertyField(ref Rect position, SerializedProperty property, bool includeChildren)
        {
            position.height = EditorGUI.GetPropertyHeight(property, includeChildren);
            var result = EditorGUI.PropertyField(position, property, includeChildren);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static bool PropertyField(ref Rect position, SerializedProperty property, GUIContent label)
        {
            var temp = new GUIContent(label);
            position.height = EditorGUI.GetPropertyHeight(property, label); // Clears 'label' contents
            var result = EditorGUI.PropertyField(position, property, label.FillWith(temp));
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static bool PropertyField(ref Rect position, SerializedProperty property, GUIContent label, bool includeChildren)
        {
            var temp = new GUIContent(label);
            position.height = EditorGUI.GetPropertyHeight(property, label, includeChildren); // Clears 'label' contents
            var result = EditorGUI.PropertyField(position, property, label.FillWith(temp), includeChildren);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static Rect RectField(ref Rect position, Rect value, GUIContent label = null)
        {
            position.height = EditorGUI.GetPropertyHeight(SerializedPropertyType.Rect, label);
            var result = EditorGUI.RectField(position, label, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static RectInt RectIntField(ref Rect position, RectInt value, GUIContent label = null)
        {
            position.height = EditorGUI.GetPropertyHeight(SerializedPropertyType.RectInt, label);
            var result = EditorGUI.RectIntField(position, label, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static string TextField(ref Rect position, string value, GUIContent label = null)
        {
            position.height = EditorGUI.GetPropertyHeight(SerializedPropertyType.String, label);
            var result = EditorGUI.TextField(position, label, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static Vector2 Vector2Field(ref Rect position, Vector2 value, GUIContent label = null)
        {
            position.height = EditorGUI.GetPropertyHeight(SerializedPropertyType.Vector2, label);
            var result = EditorGUI.Vector2Field(position, label, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static Vector2Int Vector2IntField(ref Rect position, Vector2Int value, GUIContent label = null)
        {
            position.height = EditorGUI.GetPropertyHeight(SerializedPropertyType.Vector2Int, label);
            var result = EditorGUI.Vector2IntField(position, label, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static Vector3 Vector3Field(ref Rect position, Vector3 value, GUIContent label = null)
        {
            position.height = EditorGUI.GetPropertyHeight(SerializedPropertyType.Vector3, label);
            var result = EditorGUI.Vector3Field(position, label, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static Vector3Int Vector3IntField(ref Rect position, Vector3Int value, GUIContent label = null)
        {
            position.height = EditorGUI.GetPropertyHeight(SerializedPropertyType.Vector3Int, label);
            var result = EditorGUI.Vector3IntField(position, label, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static Vector4 Vector4Field(ref Rect position, Vector4 value, GUIContent label = null)
        {
            position.height = EditorGUI.GetPropertyHeight(SerializedPropertyType.Vector4, label);
            var result = EditorGUI.Vector4Field(position, label, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static void TextureField(ref Rect position, Texture value, float size)
        {
            position.height = size;
            EditorGUI.LabelField(position, new GUIContent(value));
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
        }

        public static float GetPropertiesHeight(params SerializedProperty[] properties)
        {
            var result = 0.0f;
            foreach (var property in properties)
                result += EditorGUI.GetPropertyHeight(property) + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static void PropertyFieldChildren(ref Rect position, SerializedProperty property)
        {
            foreach (var child in property.GetChildren())
            {
                PropertyField(ref position, child);
            }
        }

        public static void PropertyFieldChildren(ref Rect position, SerializedProperty property, bool includeChildren)
        {
            foreach (var child in property.GetChildren())
            {
                PropertyField(ref position, child, includeChildren);
            }
        }

        public static float GetPropertyChildrenHeight(SerializedProperty property)
        {
            var result = 0.0f;
            foreach (var child in property.GetChildren())
                result += EditorGUI.GetPropertyHeight(child) + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static float GetPropertyChildrenHeight(SerializedProperty property, bool includeChildren)
        {
            var result = 0.0f;
            foreach (var child in property.GetChildren())
                result += EditorGUI.GetPropertyHeight(child, includeChildren) + UEditorGUIUtility.SpaceHeight;
            return result;
        }
    }
}