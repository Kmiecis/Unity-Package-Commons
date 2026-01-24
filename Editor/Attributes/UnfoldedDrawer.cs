using Common;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(UnfoldedAttribute))]
    public class UnfoldedDrawer : BasePropertyDrawer<UnfoldedAttribute>
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.GetChildren().Count() > 0)
            {
                if (attribute.labeled)
                {
                    UEditorGUI.HeaderField(ref position, label);
                }

                UEditorGUI.PropertyFieldChildren(ref position, property, true);
            }
            else
            {
                if (!attribute.labeled)
                {
                    label = GUIContent.none;
                }

                base.OnGUI(position, property, label);
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            if (property.GetChildren().Count() > 0)
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