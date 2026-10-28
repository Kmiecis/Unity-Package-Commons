using System.Collections;
using UnityEngine;

namespace Common
{
    public class SortComponent : MonoBehaviour
    {
        [SerializeField] private int _order;

        public int Order
        {
            get => _order;
            set => SetOrder(value);
        }

        public void SetOrder(int order)
        {
            _order = order;

            Reorder();
        }

        private void Reorder()
        {
            var parent = transform.parent;
            if (parent != null)
            {
                int index = 0;
                for (int i = 0; i < parent.childCount; ++i)
                {
                    var child = parent.GetChild(i);
                    if (child == transform)
                    {
                        continue;
                    }

                    if (child.TryGetComponent<SortComponent>(out var sort) &&
                        sort._order > _order)
                    {
                        break;
                    }

                    index++;
                }

                transform.SetSiblingIndex(index);
            }
        }

        private IEnumerator ReorderNextFrame()
        {
            yield return null;
            Reorder();
        }

        private void Start()
        {
            Reorder();
        }

#if UNITY_EDITOR
        private void OnValidate()
        {
            if (isActiveAndEnabled)
            {
                StartCoroutine(ReorderNextFrame());
            }
        }
#endif
    }
}