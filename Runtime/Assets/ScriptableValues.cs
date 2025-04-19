using System.Collections.Generic;
using System.Collections;
using UnityEngine;

namespace Common
{
    public static class ScriptableValues
    {
        public static ScriptableValues<T> Create<T>()
        {
            return ScriptableObject.CreateInstance<ScriptableValues<T>>();
        }

        public static ScriptableValues<T> Create<T>(T[] values)
        {
            var result = Create<T>();
            result.SetValues(values);
            return result;
        }
    }

    public class ScriptableValues<T> : ScriptableObject
    {
        [SerializeField, HideLabel]
        protected T[] _values = new T[0];

        public T[] Values
        {
            get => GetValues();
            set => SetValues(value);
        }

        public virtual T[] GetValues()
        {
            return _values;
        }

        public virtual void SetValues(T[] value)
        {
            _values = value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
                return true;

            if (ReferenceEquals(obj, null))
                return false;

            if (this.GetType() != obj.GetType())
                return false;

            return Equals((ScriptableValues<T>)obj);
        }

        public override int GetHashCode()
        {
            return ((IStructuralEquatable)this.Values).GetHashCode(EqualityComparer<T>.Default);
        }

        private bool Equals(ScriptableValues<T> other)
        {
            if (ReferenceEquals(this.Values, other.Values))
                return true;

            if (ReferenceEquals(other.Values, null))
                return false;

            if (this.Values.Length != other.Values.Length)
                return false;

            for (int i = 0; i < this.Values.Length; ++i)
            {
                if (!Equals(this.Values[i], other.Values[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}