using Common;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
    public class ReadOnlyDrawer : BasePropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            using (var scope = new EditorGUI.DisabledGroupScope(true))
            {
                EditorGUI.PropertyField(position, property, label, true);
            }
        }
    }

    [CustomPropertyDrawer(typeof(BeginReadOnlyGroupAttribute))]
    public class BeginReadOnlyGroupDrawer : DecoratorDrawer
    {
        public override float GetHeight() { return 0; }

        public override void OnGUI(Rect position)
        {
            EditorGUI.BeginDisabledGroup(true);
        }
    }

    [CustomPropertyDrawer(typeof(EndReadOnlyGroupAttribute))]
    public class EndReadOnlyGroupDrawer : DecoratorDrawer
    {
        public override float GetHeight() { return 0; }

        public override void OnGUI(Rect position)
        {
            EditorGUI.EndDisabledGroup();
        }
    }
}
