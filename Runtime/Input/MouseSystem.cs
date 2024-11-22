using UnityEngine;

namespace Common.Inputs
{
    [RequireComponent(typeof(Camera))]
    public abstract class MouseSystem : MonoBehaviour
    {
        private const int NoEventMaskSet = -1;

        [SerializeField] protected LayerMask _eventMask = NoEventMaskSet;
        [SerializeField] protected float _eventDistance = 1000.0f;
        [SerializeField] protected int _eventIntersections = 10;

        private Camera _camera;
        private RaycastHit[] _raycasts;

        private MouseDragHandler _dragger;
        private MouseHoverHandler _hoverer;

        public Camera Camera
        {
            get => _camera ?? (_camera = GetComponent<Camera>()) ?? (_camera = Camera.main);
            set => _camera = value;
        }

        public float EventDistance
        {
            get => _eventDistance > 0 ? _eventDistance : Camera.farClipPlane;
            set => _eventDistance = value;
        }

        public int EventMask
        {
            get => _eventMask & Camera.cullingMask;
            set => _eventMask = value;
        }

        private RaycastHit[] Raycasts
        {
            get => _raycasts ?? (_raycasts = new RaycastHit[_eventIntersections]);
        }

        protected abstract Vector2 GetMousePosition();

        protected abstract bool IsHeld(int button);

        protected abstract bool IsReleased(int button);

        private void HandleRelease(Vector2 screenPosition, int button)
        {
            if (_dragger != null)
            {
                var data = RaycastAnything(screenPosition);
                data.button = button;

                _dragger.OnEndDrag(data);
                _dragger = null;
            }
            else if (TryRaycastComponent<MouseClickHandler>(screenPosition, out var clicker, out var data))
            {
                data.button = button;

                clicker.OnClick(data);
            }
        }

        private void HandleDrag(Vector2 screenPosition, int button)
        {
            if (TryRaycastComponent<MouseDragHandler>(screenPosition, out var dragger, out var data))
            {
                data.button = button;

                if (_dragger == null)
                {
                    _dragger = dragger;
                    _dragger.OnBeginDrag(data);
                }
                else if (ReferenceEquals(_dragger, dragger))
                {
                    _dragger.OnDrag(data);
                }
            }
            else if (_dragger != null)
            {
                data = RaycastAnything(screenPosition);
                data.button = button;

                _dragger.OnDrag(data);
            }
        }

        private void HandleHover(Vector2 screenPosition)
        {
            if (TryRaycastComponent<MouseHoverHandler>(screenPosition, out var hoverer, out var data))
            {
                if (!ReferenceEquals(_hoverer, hoverer))
                {
                    if (_hoverer != null)
                    {
                        _hoverer.OnHoverEnd(data);
                    }

                    _hoverer = hoverer;
                    _hoverer.OnHoverBegin(data);
                }
            }
            else if (_hoverer != null)
            {
                data = RaycastAnything(screenPosition);

                _hoverer.OnHoverEnd(data);
                _hoverer = null;
            }
        }

        private bool TryRaycastComponent<T>(Vector2 screenPosition, out T component, out MouseEventData result)
        {
            var ray = Camera.ScreenPointToRay(screenPosition);
            var hits = Physics.RaycastNonAlloc(ray, Raycasts, EventDistance, EventMask);

            component = default;
            result = default;

            if (hits > 0)
            {
                var closestRaycast = (RaycastHit)default;
                var closestDistance = float.MaxValue;
                for (int i = 0; i < hits; ++i)
                {
                    var raycast = Raycasts[i];
                    if (raycast.collider.TryGetComponent<T>(out var tempComponent))
                    {
                        var distance = Vector3.Distance(raycast.point, ray.origin);
                        if (closestDistance > distance)
                        {
                            component = tempComponent;

                            closestRaycast = raycast;
                            closestDistance = distance;
                        }
                    }
                }

                if (component != null)
                {
                    result = new MouseEventData();
                    result.camera = Camera;
                    result.position = closestRaycast.point;
                    result.normal = closestRaycast.normal;

                    return true;
                }
            }

            return false;
        }

        private MouseEventData RaycastAnything(Vector2 screenPosition)
        {
            var ray = Camera.ScreenPointToRay(screenPosition);
            var hits = Physics.RaycastNonAlloc(ray, Raycasts, EventDistance, EventMask);

            var result = new MouseEventData();
            result.camera = Camera;

            if (hits > 0)
            {
                var closestRaycast = Raycasts[0];
                var closestDistance = Vector3.Distance(closestRaycast.point, ray.origin);

                for (int i = 1; i < hits; ++i)
                {
                    var raycast = Raycasts[i];

                    var distance = Vector3.Distance(raycast.point, ray.origin);
                    if (closestDistance > distance)
                    {
                        closestRaycast = raycast;
                        closestDistance = distance;
                    }
                }

                result.position = closestRaycast.point;
                result.normal = closestRaycast.normal;
            }
            else
            {
                result.position = ray.GetPoint(EventDistance);
                result.normal = -Camera.transform.forward;
            }

            return result;
        }

        private void Update()
        {
            var screenPosition = GetMousePosition();

            for (int i = 0; i < 3; ++i)
            {
                if (IsReleased(i))
                {
                    HandleRelease(screenPosition, i);
                }
                else if (IsHeld(i))
                {
                    HandleDrag(screenPosition, i);
                }
                else
                {
                    HandleHover(screenPosition);
                }
            }
        }

#if UNITY_EDITOR
        private void OnValidate()
        {
            ValidateRaycasts();
        }

        private void ValidateRaycasts()
        {
            if (_raycasts != null && _raycasts.Length != _eventIntersections)
            {
                _raycasts = null;
            }
        }
#endif
    }
}