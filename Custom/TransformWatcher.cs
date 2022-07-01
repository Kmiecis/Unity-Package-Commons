using UnityEngine;

namespace Common
{
    public class TransformWatcher
    {
        private Transform _target;

        private Vector3 _lastPosition;
        private Vector3 _lastScale;
        private Quaternion _lastRotation;

        private int _checkFrame;
        private bool _hasChanged;

        public TransformWatcher(Transform target)
        {
            _target = target;
        }

        public bool HasChanged
        {
            get
            {
                var currentFrame = Time.frameCount;
                if (currentFrame == _checkFrame)
                    return _hasChanged;

                _checkFrame = currentFrame;

                var currentPosition = _target.position;
                if (_hasChanged = (currentPosition != _lastPosition))
                {
                    _lastPosition = currentPosition;
                    return _hasChanged;
                }

                var currentScale = _target.lossyScale;
                if (_hasChanged = (currentScale != _lastScale))
                {
                    _lastScale = currentScale;
                    return _hasChanged;
                }

                var currentRotation = _target.rotation;
                if (_hasChanged = (currentRotation != _lastRotation))
                {
                    _lastRotation = currentRotation;
                    return _hasChanged;
                }

                return _hasChanged;
            }
        }
    }
}
