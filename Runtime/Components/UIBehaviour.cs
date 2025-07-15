using UnityEngine;

namespace Common
{
    [RequireComponent(typeof(RectTransform))]
    public class UIBehaviour : GameBehaviour
    {
        public RectTransform rectTransform
        {
            get => (RectTransform)transform;
        }
    }
}