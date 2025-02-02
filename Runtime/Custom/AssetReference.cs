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
        [SerializeField, HideInInspector]
        private string _extension;

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

        public string FullPath
        {
            get
            {
                return string.Concat(Path, Extension);
            }
        }

        public string Path
        {
            get
            {
#if UNITY_EDITOR
                ReadProperties();
#endif
                return _path;
            }
        }

        public string Extension
        {
            get
            {
#if UNITY_EDITOR
                ReadProperties();
#endif
                return _extension;
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
                return Path.Contains(RESOURCES);
            }
        }

        public string FullResourcePath
        {
            get
            {
                return string.Concat(ResourcePath, Extension);
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
        private void ReadProperties()
        {
            if (_value != null)
            {
                var path = AssetDatabase.GetAssetPath(_value);
                _path = UPath.RemoveExtension(path);
                _extension = System.IO.Path.GetExtension(path);
            }
            else
            {
                _path = null;
                _extension = null;
            }
        }
#endif

        #region ISerializationCallbackReceiver
        public void OnBeforeSerialize()
        {
#if UNITY_EDITOR
            ReadProperties();
#endif
        }

        public void OnAfterDeserialize()
        {
#if UNITY_EDITOR
            void ReadPropertiesOnNextUpdate()
            {
                EditorApplication.update -= ReadPropertiesOnNextUpdate;
                ReadProperties();
            }

            EditorApplication.update += ReadPropertiesOnNextUpdate;
#endif
        }
        #endregion
    }
}
