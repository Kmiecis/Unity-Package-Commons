using System;
using UnityEngine;
using UnityEngine.Events;

namespace Common.Events
{
    [Serializable]
    public class TransformEvent : UnityEvent<Transform>
    {
    }
}
