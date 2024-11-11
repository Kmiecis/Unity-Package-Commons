using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Common
{
    public class Collision2DHandler : MonoBehaviour
    {
        [SerializeField] private UnityEvent<Collision2D> _onCollisionEnter = new UnityEvent<Collision2D>();
        [SerializeField] private UnityEvent<Collision2D> _onCollisionStay = new UnityEvent<Collision2D>();
        [SerializeField] private UnityEvent<Collision2D> _onCollisionExit = new UnityEvent<Collision2D>();

        private Dictionary<Collider2D, Collision2D> _collisions;

        public Collision2DHandler()
        {
            _collisions = new Dictionary<Collider2D, Collision2D>();
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

            _collisions.Add(collision.collider, collision);
        }

        public void OnCollisionStay2D(Collision2D collision)
        {
            _onCollisionStay.Invoke(collision);
        }

        public void OnCollisionExit2D(Collision2D collision)
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