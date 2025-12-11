using Common;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(IndentAttribute))]
    public class IndentDrawer : BasePropertyDrawer<IndentAttribute>
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.indentLevel += attribute.indent;

            base.OnGUI(position, property, label);

            EditorGUI.indentLevel -= attribute.indent;
        }
    }
}