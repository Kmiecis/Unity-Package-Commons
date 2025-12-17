using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public static class UEditorGUI
    {
        public static float GetBoundsHeight(GUIContent label = null)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.Bounds, label ?? GUIContent.none);
        }

        public static float GetBoundsIntHeight(GUIContent label = null)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.BoundsInt, label ?? GUIContent.none);
        }

        public static float GetColorHeight(GUIContent label = null)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.Color, label ?? GUIContent.none);
        }

        public static float GetCurveHeight(GUIContent label = null)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.AnimationCurve, label ?? GUIContent.none);
        }

        public static float GetDoubleHeight(GUIContent label = null)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.Float, label ?? GUIContent.none);
        }

        public static float GetFloatHeight(GUIContent label = null)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.Float, label ?? GUIContent.none);
        }

        public static float GetGradientHeight(GUIContent label = null)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.Gradient, label ?? GUIContent.none);
        }

        public static float GetHeaderHeight()
        {
            return EditorGUIUtility.singleLineHeight;
        }

        public static float GetIntHeight(GUIContent label = null)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.Integer, label ?? GUIContent.none);
        }

        public static float GetLabelHeight()
        {
            return EditorGUIUtility.singleLineHeight;
        }

        public static float GetLayerHeight(GUIContent label = null)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.LayerMask, label ?? GUIContent.none);
        }

        public static float GetMaskHeight(GUIContent label = null)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.LayerMask, label ?? GUIContent.none);
        }

        public static float GetObjectHeight(GUIContent label = null)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.ObjectReference, label ?? GUIContent.none);
        }

        public static float GetRectHeight(GUIContent label = null)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.Rect, label ?? GUIContent.none);
        }

        public static float GetRectIntHeight(GUIContent label = null)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.RectInt, label ?? GUIContent.none);
        }

        public static float GetTextAreaHeight(GUIContent content, float width, GUIStyle style = null)
        {
            return (style ?? EditorStyles.textArea).CalcHeight(content, width);
        }

        public static float GetTextHeight(GUIContent label = null)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.String, label ?? GUIContent.none);
        }

        public static float GetVector2Height(GUIContent label = null)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.Vector2, label ?? GUIContent.none);
        }

        public static float GetVector2IntHeight(GUIContent label = null)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.Vector2Int, label ?? GUIContent.none);
        }

        public static float GetVector3Height(GUIContent label = null)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.Vector3, label ?? GUIContent.none);
        }

        public static float GetVector3IntHeight(GUIContent label = null)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.Vector3Int, label ?? GUIContent.none);
        }

        public static float GetVector4Height(GUIContent label = null)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.Vector4, label ?? GUIContent.none);
        }

        public static Bounds BoundsField(ref Rect position, Bounds value, GUIContent label = null)
        {
            position.height = GetBoundsHeight(label);
            var result = EditorGUI.BoundsField(position, label ?? GUIContent.none, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static BoundsInt BoundsIntField(ref Rect position, BoundsInt value, GUIContent label = null)
        {
            position.height = GetBoundsIntHeight(label);
            var result = EditorGUI.BoundsIntField(position, label ?? GUIContent.none, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static Color ColorField(ref Rect position, Color value, GUIContent label = null)
        {
            position.height = GetColorHeight(label);
            var result = EditorGUI.ColorField(position, label ?? GUIContent.none, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static AnimationCurve CurveField(ref Rect position, AnimationCurve value, GUIContent label = null)
        {
            position.height = GetCurveHeight(label);
            var result = EditorGUI.CurveField(position, label ?? GUIContent.none, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static double DoubleField(ref Rect position, double value, GUIContent label = null)
        {
            position.height = GetDoubleHeight(label);
            var result = EditorGUI.DoubleField(position, label ?? GUIContent.none, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static void DynamicHeaderField(ref Rect position, GUIContent label)
        {
            var style = new GUIStyle(EditorStyles.label) { wordWrap = true };
            position.height = GetTextAreaHeight(label, position.width, style);
            EditorGUI.LabelField(position, label);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
        }

        public static float FloatField(ref Rect position, float value, GUIContent label = null)
        {
            position.height = GetFloatHeight(label);
            var result = EditorGUI.FloatField(position, label ?? GUIContent.none, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static Gradient GradientField(ref Rect position, Gradient value, GUIContent label = null)
        {
            position.height = GetGradientHeight(label);
            var result = EditorGUI.GradientField(position, label ?? GUIContent.none, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static void HeaderField(ref Rect position, GUIContent label)
        {
            position.height = GetHeaderHeight();
            EditorGUI.LabelField(position, label);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
        }

        public static int IntField(ref Rect position, int value, GUIContent label = null)
        {
            position.height = GetIntHeight(label);
            var result = EditorGUI.IntField(position, label ?? GUIContent.none, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static void LabelField(ref Rect position, GUIContent label)
        {
            position.height = GetLabelHeight();
            EditorGUI.LabelField(position, label);
        }

        public static int LayerField(ref Rect position, int value, GUIContent label = null)
        {
            position.height = GetLayerHeight(label);
            var result = EditorGUI.LayerField(position, label ?? GUIContent.none, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static int MaskField(ref Rect position, int value, string[] options, GUIContent label = null)
        {
            position.height = GetMaskHeight(label);
            var result = EditorGUI.MaskField(position, label ?? GUIContent.none, value, options);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static void ObjectField(ref Rect position, Object value, System.Type type, bool allowSceneObjects, GUIContent label = null)
        {
            position.height = GetObjectHeight(label);
            var result = EditorGUI.ObjectField(position, label ?? GUIContent.none, value, type, allowSceneObjects);
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
            var result = EditorGUI.PropertyField(position, property, temp);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static bool PropertyField(ref Rect position, SerializedProperty property, GUIContent label, bool includeChildren)
        {
            var temp = new GUIContent(label);
            position.height = EditorGUI.GetPropertyHeight(property, label, includeChildren); // Clears 'label' contents
            var result = EditorGUI.PropertyField(position, property, temp, includeChildren);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static Rect RectField(ref Rect position, Rect value, GUIContent label = null)
        {
            position.height = GetRectHeight(label);
            var result = EditorGUI.RectField(position, label ?? GUIContent.none, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static RectInt RectIntField(ref Rect position, RectInt value, GUIContent label = null)
        {
            position.height = GetRectIntHeight(label);
            var result = EditorGUI.RectIntField(position, label ?? GUIContent.none, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static string TextArea(ref Rect position, string value, GUIStyle style = null)
        {
            position.height = GetTextAreaHeight(new GUIContent(value), position.width, style);
            var result = EditorGUI.TextArea(position, value, style ?? EditorStyles.textArea);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static string TextField(ref Rect position, string value, GUIContent label = null)
        {
            position.height = GetTextHeight(label);
            var result = EditorGUI.TextField(position, label ?? GUIContent.none, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static Vector2 Vector2Field(ref Rect position, Vector2 value, GUIContent label = null)
        {
            position.height = GetVector2Height(label);
            var result = EditorGUI.Vector2Field(position, label ?? GUIContent.none, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static Vector2Int Vector2IntField(ref Rect position, Vector2Int value, GUIContent label = null)
        {
            position.height = GetVector2IntHeight(label);
            var result = EditorGUI.Vector2IntField(position, label ?? GUIContent.none, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static Vector3 Vector3Field(ref Rect position, Vector3 value, GUIContent label = null)
        {
            position.height = GetVector3Height(label);
            var result = EditorGUI.Vector3Field(position, label ?? GUIContent.none, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static Vector3Int Vector3IntField(ref Rect position, Vector3Int value, GUIContent label = null)
        {
            position.height = GetVector3IntHeight(label);
            var result = EditorGUI.Vector3IntField(position, label ?? GUIContent.none, value);
            position.y += position.height + UEditorGUIUtility.SpaceHeight;
            return result;
        }

        public static Vector4 Vector4Field(ref Rect position, Vector4 value, GUIContent label = null)
        {
            position.height = GetVector4Height(label);
            var result = EditorGUI.Vector4Field(position, label ?? GUIContent.none, value);
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