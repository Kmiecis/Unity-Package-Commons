using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Common
{
    [AddComponentMenu(nameof(Common) + "/Physics/Collision Handler")]
    public class CollisionHandler : MonoBehaviour
    {
        [SerializeField] protected UnityEvent<Collision> _onCollisionEnter = new UnityEvent<Collision>();
        [SerializeField] protected UnityEvent<Collision> _onCollisionStay = new UnityEvent<Collision>();
        [SerializeField] protected UnityEvent<Collision> _onCollisionExit = new UnityEvent<Collision>();

        private Dictionary<Collider, Collision> _collisions;
        private Dictionary<Collider, int> _contacts;

        public CollisionHandler()
        {
            _collisions = new Dictionary<Collider, Collision>();
            _contacts = new Dictionary<Collider, int>();
        }

        public UnityEvent<Collision> OnCollisionEntered
        {
            get => _onCollisionEnter;
        }

        public UnityEvent<Collision> OnCollisionStayed
        {
            get => _onCollisionStay;
        }

        public UnityEvent<Collision> OnCollisionExited
        {
            get => _onCollisionExit;
        }

        public bool IsColliding
        {
            get => _collisions.Count > 0;
        }

        public void RemoveAllListeners()
        {
            _onCollisionEnter.RemoveAllListeners();
            _onCollisionStay.RemoveAllListeners();
            _onCollisionExit.RemoveAllListeners();
        }

        public void OnCollisionEnter(Collision collision)
        {
            _onCollisionEnter.Invoke(collision);

            var collider = collision.collider;
            _collisions[collider] = collision;
            _contacts[collider] = _contacts.GetOrDefault(collider) + 1;
        }

        public void OnCollisionStay(Collision collision)
        {
            _onCollisionStay.Invoke(collision);
        }

        public void OnCollisionExit(Collision collision)
        {
            var collider = collision.collider;
            if (_contacts.TryGetValue(collider, out var count) && count > 1)
            {
                _contacts[collider] = count - 1;
            }
            else
            {
                _contacts.Remove(collider);
                _collisions.Remove(collider);
            }

            _onCollisionExit.Invoke(collision);
        }

        private void OnDisable()
        {
            foreach (var entry in _collisions)
            {
                _onCollisionExit.Invoke(entry.Value);
            }

            _collisions.Clear();
            _contacts.Clear();
        }

        private void OnDestroy()
        {
            RemoveAllListeners();
        }
    }
}