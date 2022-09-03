using System;
using UnityEngine.Events;

namespace Common.Events
{
    [Serializable]
    public sealed class IntEvent : UnityEvent<int>
    {
    }
}
