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
            _value = value;
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

        private bool Equals(ScriptableValue<T> other)
        {
            return Equals(this.Value, other.Value);
        }
    }
}