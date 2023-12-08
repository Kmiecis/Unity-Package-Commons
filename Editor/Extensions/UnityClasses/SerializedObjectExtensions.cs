using System;
using UnityEditor;

namespace CommonEditor.Extensions
{
    public static class SerializedObjectExtensions
    {
        public static Type GetTargetType(this SerializedObject self)
        {
            if (self.isEditingMultipleObjects)
            {
                var single = self.targetObjects[0];
                return single.GetType();
            }
            return self.targetObject.GetType();
        }
    }
}