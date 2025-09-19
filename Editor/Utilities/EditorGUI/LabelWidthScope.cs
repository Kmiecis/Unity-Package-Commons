using System;
using UnityEditor;

namespace CommonEditor
{
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