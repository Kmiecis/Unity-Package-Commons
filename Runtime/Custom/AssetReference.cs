using System;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Common
{
    [Serializable]
    public class AssetReference : ISerializationCallbackReceiver
    {
        private const string RESOURCES = "Resources";

#if UNITY_EDITOR
        [SerializeField]
        private Object _value;
#endif
        [SerializeField, HideInInspector]
        private string _path;

        public Object Asset
        {
            get
            {
#if UNITY_EDITOR
                return _value;
#else
                if (IsInResources)
                {
                    return Resources.Load(ResourcePath);
                }
                return null;
#endif
            }
        }

        public string Path
        {
            get
            {
#if UNITY_EDITOR
                UpdatePath();
#endif
                return _path;
            }
        }

        public string Name
        {
            get
            {
                return System.IO.Path.GetFileName(Path);
            }
        }

        public bool IsInResources
        {
            get
            {
                return _path.Contains(RESOURCES);
            }
        }

        public string ResourcePath
        {
            get
            {
                return UPath.GetPathFrom(Path, RESOURCES);
            }
        }

#if UNITY_EDITOR
        private void UpdatePath()
        {
            _path = _value != null ? AssetDatabase.GetAssetPath(_value) : null;
        }
#endif

        #region ISerializationCallbackReceiver
        public void OnBeforeSerialize()
        {
#if UNITY_EDITOR
            UpdatePath();
#endif
        }

        public void OnAfterDeserialize()
        {
#if UNITY_EDITOR
            void UpdateNameOnNextUpdate()
            {
                EditorApplication.update -= UpdateNameOnNextUpdate;
                UpdatePath();
            }

            EditorApplication.update += UpdateNameOnNextUpdate;
#endif
        }
        #endregion
    }
}
