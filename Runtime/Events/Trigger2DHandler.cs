using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Common
{
    [AddComponentMenu(nameof(Common) + "/Physics/Trigger2D Handler")]
    public class Trigger2DHandler : MonoBehaviour
    {
        [SerializeField] protected UnityEvent<Collider2D> _onTriggerEnter = new UnityEvent<Collider2D>();
        [SerializeField] protected UnityEvent<Collider2D> _onTriggerStay = new UnityEvent<Collider2D>();
        [SerializeField] protected UnityEvent<Collider2D> _onTriggerExit = new UnityEvent<Collider2D>();

        private Dictionary<Collider2D, int> _colliders;
        private List<Collider2D> _invalids;

        public Trigger2DHandler()
        {
            _colliders = new Dictionary<Collider2D, int>();
            _invalids = new List<Collider2D>();
        }

        public UnityEvent<Collider2D> OnTriggerEntered
        {
            get => _onTriggerEnter;
        }

        public UnityEvent<Collider2D> OnTriggerStayed
        {
            get => _onTriggerStay;
        }

        public UnityEvent<Collider2D> OnTriggerExited
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

        public void OnTriggerEnter2D(Collider2D collider)
        {
            _onTriggerEnter.Invoke(collider);

            _colliders[collider] = _colliders.GetOrDefault(collider) + 1;
        }

        public void OnTriggerStay2D(Collider2D collider)
        {
            _onTriggerStay.Invoke(collider);
        }

        public void OnTriggerExit2D(Collider2D collider)
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

        private static bool IsValid(Collider2D collider)
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