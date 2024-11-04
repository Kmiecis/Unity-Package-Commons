using System;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public static class UGUI
    {
        public const float SpaceHeight = 2.0f;

        public class BackgroundColorScope : IDisposable
        {
            private readonly Color _color;

            public BackgroundColorScope(Color color)
            {
                _color = GUI.backgroundColor;

                GUI.backgroundColor = color;
            }

            public void Dispose()
            {
                GUI.backgroundColor = _color;
            }
        }

        public class ContentColorScope : IDisposable
        {
            private readonly Color _color;

            public ContentColorScope(Color color)
            {
                _color = GUI.contentColor;

                GUI.contentColor = color;
            }

            public void Dispose()
            {
                GUI.contentColor = _color;
            }
        }

        public class ColorScope : IDisposable
        {
            private readonly Color _color;

            public ColorScope(Color color)
            {
                _color = GUI.color;

                GUI.color = color;
            }

            public void Dispose()
            {
                GUI.color = _color;
            }
        }

        public class EnabledScope : IDisposable
        {
            private readonly bool _enabled;

            public EnabledScope(bool enabled)
            {
                _enabled = GUI.enabled;

                GUI.enabled = enabled;
            }

            public void Dispose()
            {
                GUI.enabled = _enabled;
            }
        }

        public static bool Button(ref Rect position, string text)
        {
            position.height = EditorGUIUtility.singleLineHeight;
            var result = GUI.Button(position, text);
            position.y += position.height + SpaceHeight;
            return result;
        }
    }
}