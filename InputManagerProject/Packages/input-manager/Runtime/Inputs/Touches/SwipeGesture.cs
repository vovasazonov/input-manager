using System.Collections.Generic;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;

namespace Inputs.Touches
{
    internal sealed class SwipeGesture : ISwipeGesture
    {
        public event SwipeHandler Started;
        public event SwipeHandler Proceed;
        public event SwipeHandler Stopped;

        private readonly HashSet<int> _swipingFingers = new HashSet<int>();

        public SwipeGesture()
        {
            AddFingerListener();
        }
        
        private void AddFingerListener()
        {
            Touch.onFingerUp += OnFingerUp;
            Touch.onFingerMove += OnFingerMove;
        }

        private void RemoveFingerListener()
        {
            Touch.onFingerUp -= OnFingerUp;
            Touch.onFingerMove -= OnFingerMove;
        }

        private void OnFingerUp(Finger finger)
        {
            var fingerId = finger.index;
            
            if (_swipingFingers.Contains(fingerId))
            {
                _swipingFingers.Remove(fingerId);
                var swipeInfo = GetSwipeInfo(finger);
                CallStopped(swipeInfo);
            }
        }

        private void OnFingerMove(Finger finger)
        {
            var swipeInfo = GetSwipeInfo(finger);
            var fingerId = finger.index;

            if (_swipingFingers.Contains(fingerId))
            {
                CallProceed(swipeInfo);
            }
            else
            {
                _swipingFingers.Add(fingerId);
                CallStarted(swipeInfo);
            }
        }

        private SwipeInfo GetSwipeInfo(Finger finger)
        {
            var touch = finger.currentTouch;
            var startScreenPosition = touch.startScreenPosition;
            IVector2 startPosition = new UnityVector(startScreenPosition);
            var currentScreenPosition = touch.screenPosition;
            IVector2 currentPosition = new UnityVector(currentScreenPosition);
            
            return new SwipeInfo(finger.index, startPosition, currentPosition);
        }

        private void CallStarted(SwipeInfo swipeInfo)
        {
            Started?.Invoke(swipeInfo);
        }

        private void CallProceed(SwipeInfo swipeInfo)
        {
            Proceed?.Invoke(swipeInfo);
        }

        private void CallStopped(SwipeInfo swipeInfo)
        {
            Stopped?.Invoke(swipeInfo);
        }
    }
}