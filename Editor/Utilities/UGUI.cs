using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public static class UGUI
    {
        public const float SpaceHeight = 2.0f;

        public static bool Button(ref Rect position, string text)
        {
            position.height = EditorGUIUtility.singleLineHeight;
            var result = GUI.Button(position, text);
            position.y += position.height + SpaceHeight;
            return result;
        }
    }
}