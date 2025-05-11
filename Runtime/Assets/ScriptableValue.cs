using System;
using UnityEngine;

namespace Common
{
    public static class ScriptableValue
    {
        public static ScriptableValue<T> Create<T>()
        {
            return ScriptableObject.CreateInstance<ScriptableValue<T>>();
        }

        public static ScriptableValue<T> Create<T>(T value)
        {
            var result = Create<T>();
            result.SetValue(value);
            return result;
        }
    }

    public class ScriptableValue<T> : ScriptableObject
    {
        [SerializeField] protected T _value;

        protected event Action<T> _callback;

        public T Value
        {
            get => GetValue();
            set => SetValue(value);
        }

        public virtual T GetValue()
        {
            return _value;
        }

        public virtual void SetValue(T value)
        {
            Invoke(value);

            _value = value;
        }

        public void AddListener(Action<T> callback)
        {
            _callback += callback;
        }

        public void RemoveListener(Action<T> callback)
        {
            _callback -= callback;
        }

        public void RemoveAllListeners()
        {
            _callback = null;
        }

        public void Invoke()
        {
            Invoke(_value);
        }

        protected void Invoke(T value)
        {
            _callback?.Invoke(value);
        }

        private bool Equals(ScriptableValue<T> other)
        {
            return Equals(this.Value, other.Value);
        }

        public static implicit operator T(ScriptableValue<T> value)
        {
            return value.Value;
        }

        public static explicit operator ScriptableValue<T>(T value)
        {
            return ScriptableValue.Create(value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
                return true;

            if (ReferenceEquals(obj, null))
                return false;

            if (this.GetType() != obj.GetType())
                return false;

            return Equals((ScriptableValue<T>)obj);
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}