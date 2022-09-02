using System;
using UnityEngine;
using UnityEngine.Events;

namespace Common.Events
{
    [Serializable]
    public class Collider2DEvent : UnityEvent<Collider2D>
    {
    }
}
