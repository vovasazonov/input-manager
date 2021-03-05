using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.OnScreen;

namespace Inputs
{
    public sealed class ScreenStick : OnScreenControl, IPointerDownHandler, IDragHandler, IPointerUpHandler
    {
        [SerializeField] [InputControl(layout = "Vector2")]
        private string _controlPath;

        [SerializeField] private RectTransform _stickArea;
        [SerializeField] private RectTransform _handleArea;
        [SerializeField] private RectTransform _handle;
        [SerializeField] private float _handleRange = 50;
        [SerializeField] private bool _allowHideHandleArea;

        private Vector2 _downPointerPosition;
        private Vector2 _handleAnchored;
        private Vector2 _handleAreaAnchored;

        protected override string controlPathInternal
        {
            get => _controlPath;
            set => _controlPath = value;
        }

        private void Start()
        {
            SetDisplayHandleArea(false);
            InitializeAnchors();
        }

        private void SetDisplayHandleArea(bool isDisplay)
        {
            if (_allowHideHandleArea)
            {
                _handleArea.gameObject.SetActive(isDisplay);
            }
        }

        public void OnDrag(PointerEventData eventData)
        {
            CalculateCurrentHandlePosition(eventData);
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            SetDisplayHandleArea(true);
            MoveHandleAreaToDownPointerPosition(eventData);
            SaveDownPointerPosition(eventData);
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            SetDisplayHandleArea(false);
            ResetValuesToDefault();
        }

        private void SaveDownPointerPosition(PointerEventData eventData)
        {
            RectTransformUtility.ScreenPointToLocalPointInRectangle(_stickArea, eventData.position, eventData.pressEventCamera, out _downPointerPosition);
        }

        private void MoveHandleAreaToDownPointerPosition(PointerEventData eventData)
        {
            RectTransformUtility.ScreenPointToLocalPointInRectangle(_stickArea, eventData.position, eventData.pressEventCamera, out var localPosition);
            _handleArea.anchoredPosition = localPosition;
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
            RectTransformUtility.ScreenPointToLocalPointInRectangle(_stickArea, eventData.position, eventData.pressEventCamera, out var dragPointerPosition);
            var delta = dragPointerPosition - _downPointerPosition;
            delta = Vector2.ClampMagnitude(delta, _handleRange);
            return delta;
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

        private void SetCurrentHandlerPosition(Vector2 position)
        {
            SendValueToControl(position);
        }
    }
}