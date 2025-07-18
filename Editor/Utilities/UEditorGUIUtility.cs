using System;
using UnityEditor;

namespace CommonEditor
{
    public static class UEditorGUIUtility
    {
        public const float SpaceHeight = 2.0f;
        public const float IndentWidth = 15.0f;

        public static float LineHeight => EditorGUIUtility.singleLineHeight + SpaceHeight;

        public class LabelWidthScope : IDisposable
        {
            private readonly float _labelWidth;

            public float LabelWidth
            {
                set => EditorGUIUtility.labelWidth = value;
            }

            public LabelWidthScope()
            {
                _labelWidth = EditorGUIUtility.labelWidth;
            }

            public LabelWidthScope(float labelWidth) : this()
            {
                LabelWidth = labelWidth;
            }

            public void Dispose()
            {
                EditorGUIUtility.labelWidth = _labelWidth;
            }
        }
    }
}