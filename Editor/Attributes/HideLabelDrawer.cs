using Common;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(HideLabelAttribute))]
    public class HideLabelDrawer : BasePropertyDrawer<HideLabelAttribute>
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            base.OnGUI(position, property, GUIContent.none);
        }
    }
}
