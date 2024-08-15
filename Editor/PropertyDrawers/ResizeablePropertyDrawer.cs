using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public class ResizeablePropertyDrawer : PropertyDrawer
    {
        private float _heightMin;
        private float _heightMax;

        protected void MarkHeightBegin(float value)
        {
            _heightMin = value;
        }

        protected void MarkHeightEnd(float value)
        {
            _heightMax = value;
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return _heightMax - _heightMin - UEditorGUIUtility.SpaceHeight;
        }
    }
}