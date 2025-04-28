using UnityEngine;

namespace Common
{
    [ExecuteAlways]
    public class OnLocalTransformChangedSender : MonoBehaviour
    {
        private const string MethodName = "OnLocalTransformChanged";

        private int _lastFrame;

        private Vector3 _lastPosition;
        private Vector3 _lastScale;
        private Quaternion _lastRotation;

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
            _lastPosition = transform.localPosition;
            _lastScale = transform.localScale;
            _lastRotation = transform.localRotation;

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
            var currentPosition = transform.localPosition;
            if (currentPosition != _lastPosition)
            {
                _lastPosition = currentPosition;
                return true;
            }

            var currentScale = transform.localScale;
            if (currentScale != _lastScale)
            {
                _lastScale = currentScale;
                return true;
            }

            var currentRotation = transform.localRotation;
            if (currentRotation != _lastRotation)
            {
                _lastRotation = currentRotation;
                return true;
            }

            return false;
        }

        private void SendChangedMessage()
        {
            SendMessage(MethodName, SendMessageOptions.DontRequireReceiver);
        }

        #region Unity
        private void Update()
        {
            CheckDirty();
        }
        #endregion
    }
}