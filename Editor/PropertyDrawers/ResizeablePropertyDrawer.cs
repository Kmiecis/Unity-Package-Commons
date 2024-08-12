using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public class ResizeablePropertyDrawer : PropertyDrawer
    {
        protected float _heightMin;
        protected float _heightMax;

        private float _height;

        protected void CheckHeight(SerializedProperty property)
        {
            var dheight = _heightMax - _heightMin;
            if (!Mathf.Approximately(_height, dheight))
            {
                EditorUtility.SetDirty(property.serializedObject.targetObject);
                _height = dheight;
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return _height;
        }
    }
}