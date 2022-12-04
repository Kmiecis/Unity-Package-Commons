using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Common
{
    [Serializable]
    public class SceneReference : ISerializationCallbackReceiver
    {
#if UNITY_EDITOR
        [SerializeField]
        private SceneAsset _scene;
#endif
        [SerializeField, HideInInspector]
        private string _name;

        public string Name
        {
            get
            {
#if UNITY_EDITOR
                UpdateName();
#endif
                return _name;
            }
        }

#if UNITY_EDITOR
        private void UpdateName()
        {
            if (_scene == null)
            {
                _name = null;
            }
            else
            {
                var path = AssetDatabase.GetAssetPath(_scene);
                _name = Path.GetFileNameWithoutExtension(path);
            }
        }
#endif

        #region ISerializationCallbackReceiver
        public void OnBeforeSerialize()
        {
#if UNITY_EDITOR
            UpdateName();
#endif
        }

        public void OnAfterDeserialize()
        {
#if UNITY_EDITOR
            void UpdateNameOnNextUpdate()
            {
                EditorApplication.update -= UpdateNameOnNextUpdate;
                UpdateName();
            }

            EditorApplication.update += UpdateNameOnNextUpdate;
#endif
        }
        #endregion
    }
}
