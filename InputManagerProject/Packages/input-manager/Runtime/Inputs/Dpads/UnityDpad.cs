using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.OnScreen;

namespace Inputs.Dpads
{
    public sealed class UnityDpad : OnScreenControl, IDpad, IPointerDownHandler, IDragHandler, IPointerUpHandler
    {
        [SerializeField] [InputControl(layout = "Vector2")]
        private string _controlPath;

        [SerializeField] private RectTransform _dpadArea;
        [SerializeField] private RectTransform _handleArea;
        [SerializeField] private RectTransform _handle;
        [SerializeField] private float _handleRange = 50;

        private Vector2 _handleAreaAnchored;
        private Vector2 _handleAnchored;
        private Vector2 _downPointerPosition;
        private Vector2 _currentHandlePosition;
        
        protected override string controlPathInternal
        {
            get => _controlPath;
            set => _controlPath = value;
        }

        public IVector2 Position => new CustomVector2(_currentHandlePosition.x, _currentHandlePosition.y);

        private void Start()
        {
            InitializeAnchors();
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            MoveHandleAreaToDownPointerPosition(eventData);
            SaveDownPointerPosition(eventData);
        }

        private void SaveDownPointerPosition(PointerEventData eventData)
        {
            RectTransformUtility.ScreenPointToLocalPointInRectangle(_dpadArea, eventData.position, eventData.pressEventCamera, out _downPointerPosition);
        }

        private void MoveHandleAreaToDownPointerPosition(PointerEventData eventData)
        {
            RectTransformUtility.ScreenPointToLocalPointInRectangle(_dpadArea, eventData.position, eventData.pressEventCamera, out var localPosition);
            _handleArea.anchoredPosition = localPosition;
        }

        public void OnDrag(PointerEventData eventData)
        {
            CalculateCurrentHandlePosition(eventData);
        }

        private void CalculateCurrentHandlePosition(PointerEventData eventData)
        {
            var handleDeltaRange = CalculateHandleDeltaRange(eventData);
            _handle.anchoredPosition = _handleAnchored + handleDeltaRange;
            var currentHandlePosition = new Vector2(handleDeltaRange.x / _handleRange, handleDeltaRange.y / _handleRange);
            SetCurrentHandlerPosition(currentHandlePosition);
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
            ResetValuesToDefault();
            SendValueToControl(Vector2.zero);
        }

        private void InitializeAnchors()
        {
            _handleAnchored = _handle.anchoredPosition;
            _handleAreaAnchored = _handleArea.anchoredPosition;
        }

        private void ResetValuesToDefault()
        {
            SetCurrentHandlerPosition(Vector2.zero);
            _handleArea.anchoredPosition = _handleAreaAnchored;
            _handle.anchoredPosition = _handleAnchored;
        }

        private void SetCurrentHandlerPosition(Vector2 value)
        {
            _currentHandlePosition = value;
            SendValueToControl(value);
        }
    }
}