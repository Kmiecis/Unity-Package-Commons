using System;
using UnityEngine;
using UnityEngine.Events;

namespace Common.Events
{
    [Serializable]
    public sealed class TransformEvent : UnityEvent<Transform>
    {
    }
}
