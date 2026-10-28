using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Common
{
    [AddComponentMenu(nameof(Common) + "/Physics/Trigger Handler")]
    public class TriggerHandler : MonoBehaviour
    {
        [SerializeField] protected UnityEvent<Collider> _onTriggerEnter = new UnityEvent<Collider>();
        [SerializeField] protected UnityEvent<Collider> _onTriggerStay = new UnityEvent<Collider>();
        [SerializeField] protected UnityEvent<Collider> _onTriggerExit = new UnityEvent<Collider>();

        private Dictionary<Collider, int> _colliders;
        private List<Collider> _invalids;

        public TriggerHandler()
        {
            _colliders = new Dictionary<Collider, int>();
            _invalids = new List<Collider>();
        }

        public UnityEvent<Collider> OnTriggerEntered
        {
            get => _onTriggerEnter;
        }

        public UnityEvent<Collider> OnTriggerStayed
        {
            get => _onTriggerStay;
        }

        public UnityEvent<Collider> OnTriggerExited
        {
            get => _onTriggerExit;
        }

        public bool IsColliding
        {
            get
            {
                RemoveInvalidColliders();
                return _colliders.Count > 0;
            }
        }

        public void RemoveAllListeners()
        {
            _onTriggerEnter.RemoveAllListeners();
            _onTriggerStay.RemoveAllListeners();
            _onTriggerExit.RemoveAllListeners();
        }

        public void OnTriggerEnter(Collider collider)
        {
            _onTriggerEnter.Invoke(collider);

            _colliders[collider] = _colliders.GetOrDefault(collider) + 1;
        }

        public void OnTriggerStay(Collider collider)
        {
            _onTriggerStay.Invoke(collider);
        }

        public void OnTriggerExit(Collider collider)
        {
            if (_colliders.TryGetValue(collider, out var count) && count > 1)
            {
                _colliders[collider] = count - 1;
            }
            else
            {
                _colliders.Remove(collider);
            }

            _onTriggerExit.Invoke(collider);
        }

        private static bool IsValid(Collider collider)
        {
            return (
                collider != null &&
                collider.enabled &&
                collider.gameObject.activeInHierarchy
            );
        }

        private void RemoveInvalidColliders()
        {
            foreach (var collider in _colliders.Keys)
            {
                if (!IsValid(collider))
                {
                    _invalids.Add(collider);
                }
            }

            foreach (var collider in _invalids)
            {
                _colliders.Remove(collider);
            }

            _invalids.Clear();
        }

        private void OnDisable()
        {
            RemoveInvalidColliders();

            foreach (var collider in _colliders.Keys)
            {
                _onTriggerExit.Invoke(collider);
            }

            _colliders.Clear();
        }

        private void OnDestroy()
        {
            RemoveAllListeners();
        }
    }
}