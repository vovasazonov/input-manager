using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.OnScreen;
using UnityEngine.UI;

namespace Inputs
{
    public sealed class ScreenStick : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
    {
        [SerializeField] private RectTransform _stickAreaTransform;
        [SerializeField] private RectTransform _handleAreaTransform;
        [SerializeField] private RectTransform _handleTransform;
        [SerializeField] private Image _handleAreaImage;
        [SerializeField] private Image _handleImage;
        [SerializeField] private OnScreenStick _onScreenStick;
        [SerializeField] private bool _isAllowMove;
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
                _handleAreaImage.enabled = isDisplay;
                _handleImage.enabled = isDisplay;
            }
        }

        public void OnDrag(PointerEventData eventData)
        {
            if (_isAllowMove)
            {
                _onScreenStick.OnDrag(eventData);
            }
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            SetDisplayHandleArea(true);
            if (_isAllowMove)
            {
                MoveHandleAreaToDownPointerPosition(eventData);
            }

        }

        public void OnPointerUp(PointerEventData eventData)
        {
            SetDisplayHandleArea(false);
            ResetValuesToDefault();
            _onScreenStick.OnPointerUp(eventData);
        }

        private void MoveHandleAreaToDownPointerPosition(PointerEventData eventData)
        {
            RectTransformUtility.ScreenPointToLocalPointInRectangle(_stickAreaTransform, eventData.position, eventData.pressEventCamera, out var localPosition);
            _handleAreaTransform.anchoredPosition = localPosition;
        }

        private void InitializeAnchors()
        {
            _handleAnchored = _handleTransform.anchoredPosition;
            _handleAreaAnchored = _handleAreaTransform.anchoredPosition;
        }

        private void ResetValuesToDefault()
        {
            _handleAreaTransform.anchoredPosition = _handleAreaAnchored;
            _handleTransform.anchoredPosition = _handleAnchored;
        }
    }
}