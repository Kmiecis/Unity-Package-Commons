using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public static class UEditorGUILayout
    {
        public static void Line(float height, Color color)
        {
            var rect = EditorGUILayout.GetControlRect(false, height);
            rect.height = height;
            EditorGUI.DrawRect(rect, color);
        }

        public static void Line(Color color)
            => Line(1.0f, color);

        public static void Line(float height)
            => Line(height, Color.black);

        public static void Line()
            => Line(1.0f);
    }
}