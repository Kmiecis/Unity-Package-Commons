using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Common
{
    public class TriggerHandler : MonoBehaviour
    {
        [SerializeField] private UnityEvent<Collider> _onTriggerEnter = new UnityEvent<Collider>();
        [SerializeField] private UnityEvent<Collider> _onTriggerStay = new UnityEvent<Collider>();
        [SerializeField] private UnityEvent<Collider> _onTriggerExit = new UnityEvent<Collider>();

        private List<Collider> _colliders;

        public TriggerHandler()
        {
            _colliders = new List<Collider>();
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
            get => _colliders.Count > 0;
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

            _colliders.Add(collider);
        }

        public void OnTriggerStay(Collider collider)
        {
            _onTriggerStay.Invoke(collider);
        }

        public void OnTriggerExit(Collider collider)
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