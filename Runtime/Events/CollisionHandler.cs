using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Common
{
    public class CollisionHandler : MonoBehaviour
    {
        [SerializeField] private UnityEvent<Collision> _onCollisionEnter = new UnityEvent<Collision>();
        [SerializeField] private UnityEvent<Collision> _onCollisionStay = new UnityEvent<Collision>();
        [SerializeField] private UnityEvent<Collision> _onCollisionExit = new UnityEvent<Collision>();

        private Dictionary<Collider, Collision> _collisions;

        public CollisionHandler()
        {
            _collisions = new Dictionary<Collider, Collision>();
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

            _collisions.Add(collision.collider, collision);
        }

        public void OnCollisionStay(Collision collision)
        {
            _onCollisionStay.Invoke(collision);
        }

        public void OnCollisionExit(Collision collision)
        {
            _collisions.Remove(collision.collider);

            _onCollisionExit.Invoke(collision);
        }

        private void OnDisable()
        {
            foreach (var entry in _collisions)
            {
                _onCollisionExit.Invoke(entry.Value);
            }

            _collisions.Clear();
        }

        private void OnDestroy()
        {
            RemoveAllListeners();
        }
    }
}