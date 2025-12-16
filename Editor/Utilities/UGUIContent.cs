using UnityEngine;

namespace CommonEditor
{
    public static class UGUIContent
    {
        private static readonly GUIContent _TempContent;

        static UGUIContent()
        {
            _TempContent = new GUIContent();
        }

        public static GUIContent TempContent(GUIContent source)
        {
            _TempContent.text = source.text;
            _TempContent.image = source.image;
            _TempContent.tooltip = source.tooltip;
            return _TempContent;
        }
    }
}