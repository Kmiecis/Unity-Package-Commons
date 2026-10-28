using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

namespace Common
{
    [Serializable]
    public class SceneReference : ISerializationCallbackReceiver
    {
#if UNITY_EDITOR
        [SerializeField]
        private Object _value;
#endif
        [SerializeField, HideInInspector]
        private string _name;

        public void Load()
        {
            SceneManager.LoadScene(_name);
        }

        public void Append()
        {
            SceneManager.LoadScene(_name, LoadSceneMode.Additive);
        }

        public AsyncOperation LoadAsync()
        {
            return SceneManager.LoadSceneAsync(_name);
        }

        public AsyncOperation AppendAsync()
        {
            return SceneManager.LoadSceneAsync(_name, LoadSceneMode.Additive);
        }

        public void Unload()
        {
#pragma warning disable 0618
            SceneManager.UnloadScene(_name);
#pragma warning restore
        }

        public AsyncOperation UnloadAsync()
        {
            return SceneManager.UnloadSceneAsync(_name);
        }

#if UNITY_EDITOR
        private void ReadAssetName()
        {
            if (_value != null)
            {
                var path = UnityEditor.AssetDatabase.GetAssetPath(_value);
                _name = Path.GetFileName(UPath.RemoveExtension(path));
            }
            else
            {
                _name = null;
            }
        }
#endif

        #region ISerializationCallbackReceiver
        public void OnBeforeSerialize()
        {
#if UNITY_EDITOR
            ReadAssetName();
#endif
        }

        public void OnAfterDeserialize()
        {
#if UNITY_EDITOR
            void ReadPropertiesOnNextUpdate()
            {
                UnityEditor.EditorApplication.update -= ReadPropertiesOnNextUpdate;
                ReadAssetName();
            }

            UnityEditor.EditorApplication.update += ReadPropertiesOnNextUpdate;
#endif
        }
        #endregion
    }
}