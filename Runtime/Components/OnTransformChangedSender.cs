using UnityEngine;

namespace Common
{
    [ExecuteAlways]
    public class OnTransformChangedSender : MonoBehaviour
    {
        public const string MethodName = "OnTransformChanged";
        public const string ParentMethodName = "OnChildTransformChanged";

        private int _lastFrame;

        private Vector3 _lastPosition = UVector3.NaN;
        private Vector3 _lastScale = UVector3.NaN;
        private Quaternion _lastRotation = UQuaternion.NaN;

        public void CheckDirty()
        {
            if (HasFrameChanged() && HasChanged())
            {
                SendChangedMessage();
            }
        }

        public void OnChange()
        {
            _lastFrame = Time.frameCount;
            _lastPosition = transform.position;
            _lastScale = transform.lossyScale;
            _lastRotation = transform.rotation;

            SendChangedMessage();
        }

        private bool HasFrameChanged()
        {
            var previous = _lastFrame;
            _lastFrame = Time.frameCount;
            return _lastFrame != previous;
        }

        private bool HasChanged()
        {
            var currentPosition = transform.position;
            if (currentPosition != _lastPosition)
            {
                _lastPosition = currentPosition;
                return true;
            }

            var currentScale = transform.lossyScale;
            if (currentScale != _lastScale)
            {
                _lastScale = currentScale;
                return true;
            }

            var currentRotation = transform.rotation;
            if (currentRotation != _lastRotation)
            {
                _lastRotation = currentRotation;
                return true;
            }

            return false;
        }

        private void SendChangedMessage()
        {
            SendChangedMessage(transform, MethodName);

            if (transform.parent != null)
            {
                SendChangedMessage(transform.parent, ParentMethodName);
            }
        }

        private static void SendChangedMessage(Transform target, string methodName)
        {
            var components = target.GetComponents<Component>();
            foreach (var component in components)
            {
                var method = component.GetType().GetMethod(methodName, UBinding.AnyInstance);
                if (method != null)
                {
                    method.Invoke(component, null);
                }
            }
        }

        #region Unity
        private void Update()
        {
            CheckDirty();
        }
        #endregion
    }
}