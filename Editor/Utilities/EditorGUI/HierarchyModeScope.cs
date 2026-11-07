using System;
using UnityEditor;

namespace CommonEditor
{
    public class HierarchyModeScope : IDisposable
    {
        private readonly bool _hierarchyMode;

        public bool HierarchyMode
        {
            set => EditorGUIUtility.hierarchyMode = value;
        }

        public HierarchyModeScope()
        {
            _hierarchyMode = EditorGUIUtility.hierarchyMode;
        }

        public HierarchyModeScope(bool hierarchyMode) : this()
        {
            HierarchyMode = hierarchyMode;
        }

        public void Dispose()
        {
            EditorGUIUtility.hierarchyMode = _hierarchyMode;
        }
    }
}