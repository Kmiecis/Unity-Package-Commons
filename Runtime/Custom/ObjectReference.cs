using System;
using System.IO;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Common
{
    [Serializable]
    public class ObjectReference : ISerializationCallbackReceiver
    {
        private const string RESOURCES = "Resources";

#if UNITY_EDITOR
        [SerializeField]
        private Object _value;
#endif
        [SerializeField, HideInInspector]
        private string _path;

        public string AssetPath
        {
            get
            {
#if UNITY_EDITOR
                UpdatePath();
#endif
                return _path;
            }
        }

        public string AssetName
        {
            get
            {
                return Path.GetFileName(AssetPath);
            }
        }

        public string ResourcePath
        {
            get
            {
                return UPath.GetPathFrom(AssetPath, RESOURCES);
            }
        }

#if UNITY_EDITOR
        private void UpdatePath()
        {
            if (_value == null)
            {
                _path = null;
            }
            else
            {
                var assetPath = AssetDatabase.GetAssetPath(_value);
                _path = UPath.GetPathWithoutExtension(assetPath);
            }
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
