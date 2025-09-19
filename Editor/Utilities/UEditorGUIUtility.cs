using Common;
using System;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public static class UEditorGUIUtility
    {
        public const float SpaceHeight = 2.0f;
        public const float IndentWidth = 15.0f;

        public static Func<MessageType, Texture2D> GetHelpIcon;

        static UEditorGUIUtility()
        {
            GetHelpIcon = ReflectGetHelpIcon();
        }

        public static float LineHeight
        {
            get => EditorGUIUtility.singleLineHeight + SpaceHeight;
        }

        private static Func<MessageType, Texture2D> ReflectGetHelpIcon()
        {
            return typeof(EditorGUIUtility)
                .GetMethod(nameof(GetHelpIcon), UBinding.NonPublicStatic)
                .AsFunc<MessageType, Texture2D>();
        }
    }
}