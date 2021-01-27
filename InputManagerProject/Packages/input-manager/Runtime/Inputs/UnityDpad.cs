using UnityEngine;
using UnityEngine.EventSystems;

namespace Inputs
{
    public sealed class UnityDpad : MonoBehaviour, IDpad, IPointerDownHandler, IDragHandler, IPointerUpHandler
    {
        [SerializeField] private RectTransform _dpadArea;
        [SerializeField] private RectTransform _handleArea;
        [SerializeField] private RectTransform _handle;
        [SerializeField] private float _handleRange = 50;

        private Vector2 _handleAreaAnchored;
        private Vector2 _handleAnchored;
        private Vector2 _downPointerPosition;
        private Vector2 _currentHandlePosition;

        public IVector2 Position => new CustomVector2(_currentHandlePosition.x, _currentHandlePosition.y);

        private void Start()
        {
            InitializeAnchors();
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            _handleArea.anchoredPosition = eventData.position;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(_dpadArea, eventData.position, eventData.pressEventCamera, out _downPointerPosition);
        }

        public void OnDrag(PointerEventData eventData)
        {
            var handleDeltaRange = CalculateHandleDeltaRange(eventData);
            _handle.anchoredPosition = _handleAnchored + handleDeltaRange;
            _currentHandlePosition = new Vector2(handleDeltaRange.x / _handleRange, handleDeltaRange.y / _handleRange);
        }

        private Vector2 CalculateHandleDeltaRange(PointerEventData eventData)
        {
            RectTransformUtility.ScreenPointToLocalPointInRectangle(_dpadArea, eventData.position, eventData.pressEventCamera, out var dragPointerPosition);
            var delta = dragPointerPosition - _downPointerPosition;
            delta = Vector2.ClampMagnitude(delta, _handleRange);
            return delta;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            _currentHandlePosition = Vector2.zero;
            SetAnchors();
        }

        private void InitializeAnchors()
        {
            _handleAnchored = _handle.anchoredPosition;
            _handleAreaAnchored = _handleArea.anchoredPosition;
        }

        private void SetAnchors()
        {
            _handleArea.anchoredPosition = _handleAreaAnchored;
            _handle.anchoredPosition = _handleAnchored;
        }
    }
}