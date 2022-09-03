using System;
using UnityEngine.Events;

namespace Common.Events
{
    [Serializable]
    public sealed class BoolEvent : UnityEvent<bool>
    {
    }
}
