using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Common
{
    [AddComponentMenu(nameof(Common) + "/Physics/Collision2D Handler")]
    public class Collision2DHandler : MonoBehaviour
    {
        [SerializeField] protected UnityEvent<Collision2D> _onCollisionEnter = new UnityEvent<Collision2D>();
        [SerializeField] protected UnityEvent<Collision2D> _onCollisionStay = new UnityEvent<Collision2D>();
        [SerializeField] protected UnityEvent<Collision2D> _onCollisionExit = new UnityEvent<Collision2D>();

        private Dictionary<Collider2D, Collision2D> _collisions;
        private Dictionary<Collider2D, int> _contacts;

        public Collision2DHandler()
        {
            _collisions = new Dictionary<Collider2D, Collision2D>();
            _contacts = new Dictionary<Collider2D, int>();
        }

        public UnityEvent<Collision2D> OnCollisionEntered
        {
            get => _onCollisionEnter;
        }

        public UnityEvent<Collision2D> OnCollisionStayed
        {
            get => _onCollisionStay;
        }

        public UnityEvent<Collision2D> OnCollisionExited
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

        public void OnCollisionEnter2D(Collision2D collision)
        {
            _onCollisionEnter.Invoke(collision);

            var collider = collision.collider;
            _collisions[collider] = collision;
            _contacts[collider] = _contacts.GetOrDefault(collider) + 1;
        }

        public void OnCollisionStay2D(Collision2D collision)
        {
            _onCollisionStay.Invoke(collision);
        }

        public void OnCollisionExit2D(Collision2D collision)
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