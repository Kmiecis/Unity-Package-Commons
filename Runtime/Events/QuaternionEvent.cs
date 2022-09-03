using System;
using UnityEngine;
using UnityEngine.Events;

namespace Common.Events
{
    [Serializable]
    public sealed class QuaternionEvent : UnityEvent<Quaternion>
    {
    }
}
