using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public static class RectExtensions
    {
        public static Rect AsLabel(this Rect self)
        {
            self.width = EditorGUIUtility.labelWidth;
            return self;
        }

        public static Rect AsField(this Rect self)
        {
            self.x += EditorGUIUtility.labelWidth + UEditorGUIUtility.SpaceWidth;
            self.width -= EditorGUIUtility.labelWidth;
            return self;
        }
    }
}