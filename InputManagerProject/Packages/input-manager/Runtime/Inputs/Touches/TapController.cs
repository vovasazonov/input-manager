using UnityEngine.InputSystem.EnhancedTouch;

namespace Inputs.Touches
{
    internal sealed class TapController : ITapController
    {
        public event TappedHandler Tapped;

        private int _currentAmountTap;

        public TapController()
        {
            AddFingerListener();
        }

        private void AddFingerListener()
        {
            Touch.onFingerUp += OnFingerUp;
        }

        private void RemoveFingerListener()
        {
            Touch.onFingerUp -= OnFingerUp;
        }

        private void OnFingerUp(Finger finger)
        {
            DetectTap(finger);
        }

        private void DetectTap(Finger finger)
        {
            var touch = finger.currentTouch;

            if (touch.isTap)
            {
                var tapScreenPosition = GetTapScreenPosition(touch);
                CallTapped(tapScreenPosition, touch.tapCount);
            }
        }

        private IVector2 GetTapScreenPosition(Touch touch)
        {
            var unityVector = touch.screenPosition;
            return new CustomVector2(unityVector.x, unityVector.y);
        }

        private void CallTapped(IVector2 screenPosition, int amountTap)
        {
            Tapped?.Invoke(screenPosition, amountTap);
        }
    }
}