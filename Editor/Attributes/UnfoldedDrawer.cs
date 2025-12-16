using Common;
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
                if (attribute.labeled)
                {
                    UEditorGUI.HeaderField(ref position, label);
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
                    result += EditorGUIUtility.singleLineHeight;
                }
                return result;
            }
            else
            {
                return base.GetPropertyHeight(property, label);
            }
        }
    }
}