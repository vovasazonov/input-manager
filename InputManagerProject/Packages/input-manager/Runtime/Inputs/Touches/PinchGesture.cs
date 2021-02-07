using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;

namespace Inputs.Touches
{
    internal sealed class PinchGesture : IPinchGesture
    {
        public event PinchHandler Started;
        public event PinchHandler Proceed;
        public event PinchHandler Stopped;

        private const int _amountFingersToPinch = 2;
        private readonly IDictionary<int, Finger> _activePinchFingers = new Dictionary<int, Finger>(2);
        private float _startMagnitude;
        private bool IsPinch => _amountFingersToPinch == _activePinchFingers.Count;

        public PinchGesture()
        {
            AddFingerListener();
        }

        private void AddFingerListener()
        {
            Touch.onFingerUp += OnFingerUp;
            Touch.onFingerMove += OnFingerMove;
            Touch.onFingerDown += OnFingerDown;
        }

        private void RemoveFingerListener()
        {
            Touch.onFingerUp -= OnFingerUp;
            Touch.onFingerMove -= OnFingerMove;
            Touch.onFingerDown -= OnFingerDown;
        }

        private void OnFingerDown(Finger finger)
        {
            DetectStartPinch(finger);
        }

        private void DetectStartPinch(Finger finger)
        {
            if (!IsPinch)
            {
                _activePinchFingers.Add(finger.index, finger);

                if (IsPinch)
                {
                    _startMagnitude = Vector2.Distance(_activePinchFingers[0].screenPosition, _activePinchFingers[1].screenPosition);
                    var pinchInfo = GetPinchInfo();
                    CallStarted(pinchInfo);
                }
            }
        }

        private void OnFingerMove(Finger finger)
        {
            if (_activePinchFingers.ContainsKey(finger.index) && IsPinch)
            {
                UpdateFinger(finger);
                var pinchInfo =  GetPinchInfo();
                CallProceed(pinchInfo);
            }
        }

        private void UpdateFinger(Finger finger)
        {
            int fingerId = finger.index;

            if (_activePinchFingers.Remove(fingerId))
            {
                _activePinchFingers.Add(fingerId, finger);
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }

        private void OnFingerUp(Finger finger)
        {
            if (_activePinchFingers.ContainsKey(finger.index))
            {
                var pinchInfo = GetPinchInfo();
                _activePinchFingers.Remove(finger.index);
                CallStopped(pinchInfo);
            }
        }

        private PinchInfo GetPinchInfo()
        {
            return new PinchInfo(_startMagnitude, _activePinchFingers[0].screenPosition, _activePinchFingers[1].screenPosition);
        }

        private void CallStarted(PinchInfo pinchInfo)
        {
            Started?.Invoke(pinchInfo);
        }

        private void CallProceed(PinchInfo pinchInfo)
        {
            Proceed?.Invoke(pinchInfo);
        }

        private void CallStopped(PinchInfo pinchInfo)
        {
            Stopped?.Invoke(pinchInfo);
        }
    }
}