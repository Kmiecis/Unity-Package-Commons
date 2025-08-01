using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Common
{
    [AddComponentMenu(nameof(Common) + "/Trigger2D Handler")]
    public class Trigger2DHandler : MonoBehaviour
    {
        [SerializeField] protected UnityEvent<Collider2D> _onTriggerEnter = new UnityEvent<Collider2D>();
        [SerializeField] protected UnityEvent<Collider2D> _onTriggerStay = new UnityEvent<Collider2D>();
        [SerializeField] protected UnityEvent<Collider2D> _onTriggerExit = new UnityEvent<Collider2D>();

        private List<Collider2D> _colliders;

        public Trigger2DHandler()
        {
            _colliders = new List<Collider2D>();
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
            get => _colliders.Count > 0;
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

            _colliders.Add(collider);
        }

        public void OnTriggerStay2D(Collider2D collider)
        {
            _onTriggerStay.Invoke(collider);
        }

        public void OnTriggerExit2D(Collider2D collider)
        {
            _colliders.Remove(collider);

            _onTriggerExit.Invoke(collider);
        }

        private void OnDisable()
        {
            foreach (var collider in _colliders)
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