using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.OnScreen;

namespace Inputs
{
    public sealed class ScreenStick : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
    {
        [SerializeField] private RectTransform _stickArea;
        [SerializeField] private RectTransform _handleArea;
        [SerializeField] private RectTransform _handle;
        [SerializeField] private OnScreenStick _onScreenStick;
        [SerializeField] private bool _allowHideHandleArea;
        
        private Vector2 _handleAnchored;
        private Vector2 _handleAreaAnchored;

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
            _onScreenStick.OnDrag(eventData);
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            SetDisplayHandleArea(true);
            MoveHandleAreaToDownPointerPosition(eventData);
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            SetDisplayHandleArea(false);
            ResetValuesToDefault();
            _onScreenStick.OnPointerUp(eventData);
        }

        private void MoveHandleAreaToDownPointerPosition(PointerEventData eventData)
        {
            RectTransformUtility.ScreenPointToLocalPointInRectangle(_stickArea, eventData.position, eventData.pressEventCamera, out var localPosition);
            _handleArea.anchoredPosition = localPosition;
        }

        private void InitializeAnchors()
        {
            _handleAnchored = _handle.anchoredPosition;
            _handleAreaAnchored = _handleArea.anchoredPosition;
        }

        private void ResetValuesToDefault()
        {
            _handleArea.anchoredPosition = _handleAreaAnchored;
            _handle.anchoredPosition = _handleAnchored;
        }
    }
}