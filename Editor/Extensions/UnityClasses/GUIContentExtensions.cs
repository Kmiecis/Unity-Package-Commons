using UnityEngine;

namespace CommonEditor
{
    public static class GUIContentExtensions
    {
        public static GUIContent FillWith(this GUIContent self, GUIContent source)
        {
            self.text = source.text;
            self.image = source.image;
            self.tooltip = source.tooltip;
            return self;
        }

        public static GUIContent CopyTo(this GUIContent self, GUIContent target)
        {
            target.text = self.text;
            target.image = self.image;
            target.tooltip = self.tooltip;
            return target;
        }
    }
}