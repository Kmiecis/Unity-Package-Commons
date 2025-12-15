using Common;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(UnfoldedAttribute))]
    public class UnfoldedDrawer : BasePropertyDrawer<UnfoldedAttribute>
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.hasChildren)
            {
                if (!attribute.labeled)
                {
                    label.text = string.Empty;
                    position.y -= EditorGUIUtility.singleLineHeight;
                }

                using (var hider = new HideFoldoutScope())
                {
                    UEditorGUI.PropertyField(ref position, property, label, false);
                }

                UEditorGUI.PropertyFieldChildren(ref position, property, true);
            }
            else
            {
                Debug.LogWarning(this.Format("Works only on properties with children"));

                base.OnGUI(position, property, label);
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            if (property.hasChildren)
            {
                var result = UEditorGUI.GetPropertyChildrenHeight(property, true);
                if (attribute.labeled)
                {
                    result += EditorGUI.GetPropertyHeight(property, label, false) + UEditorGUIUtility.SpaceHeight;
                }
                return result;
            }

            return base.GetPropertyHeight(property, label);
        }

        private class HideFoldoutScope : GUI.Scope
        {
            private FieldInfo _onDrawField;
            private object _onDrawValue;

            public HideFoldoutScope()
            {
                _onDrawField = typeof(GUIStyle).GetField("onDraw", UBinding.NonPublicStatic);
                _onDrawValue = _onDrawField.GetValue(null);

                _onDrawField.SetValue(null, null);
            }

            protected override void CloseScope()
            {
                _onDrawField.SetValue(null, _onDrawValue);
            }
        }
    }
}