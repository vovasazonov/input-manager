using UnityEngine;
using UnityEngine.InputSystem;

namespace Inputs
{
    internal sealed class SwipeAction : ISwipeAction
    {
        public event SwipeHandler Started;
        public event SwipeHandler Proceed;
        public event SwipeHandler Stopped;

        private readonly InputAction _positionAction;
        private readonly InputAction _pressReleaseAction;
        private IVector2 _startScreenPosition;
        private bool _isSwiping;
        private bool _isPressing;

        public SwipeAction(InputAction positionAction, InputAction pressReleaseAction)
        {
            _positionAction = positionAction;
            _pressReleaseAction = pressReleaseAction;

            AddActionListener();
        }

        private void AddActionListener()
        {
            _positionAction.performed += OnPositionActionPerformed;
            _pressReleaseAction.performed += OnPressReleaseActionPerformed;
        }

        private void RemoveActionListener()
        {
            _positionAction.performed -= OnPositionActionPerformed;
            _pressReleaseAction.performed -= OnPressReleaseActionPerformed;
        }

        private void OnPressReleaseActionPerformed(InputAction.CallbackContext context)
        {
            ChangeModePressRelease();
            DetectStopSwiping();
        }

        private void ChangeModePressRelease()
        {
            _isPressing = !_isPressing;
        }

        private void DetectStopSwiping()
        {
            if (!_isPressing && _isSwiping)
            {
                StopSwiping();
            }
        }

        private void DetectProceedSwiping()
        {
            if (_isSwiping && _isPressing)
            {
                ProceedSwiping();
            }
        }

        private void DetectStartSwiping()
        {
            if (!_isSwiping && _isPressing)
            {
                StartSwiping();
            }
        }

        private void OnPositionActionPerformed(InputAction.CallbackContext context)
        {
            DetectProceedSwiping();
            DetectStartSwiping();
        }

        private void StartSwiping()
        {
            _isSwiping = true;
            InitializeStartScreenPosition();
            CallStarted(GetSwipeInfo());
        }

        private void ProceedSwiping()
        {
            CallProceed(GetSwipeInfo());
        }

        private void StopSwiping()
        {
            _isSwiping = false;
            CallStopped(GetSwipeInfo());
        }

        private SwipeInfo GetSwipeInfo()
        {
            return new SwipeInfo(_startScreenPosition, GetCurrentScreenPosition());
        }

        private void InitializeStartScreenPosition()
        {
            _startScreenPosition = GetCurrentScreenPosition();
        }

        private IVector2 GetCurrentScreenPosition()
        {
            var position = _positionAction.ReadValue<Vector2>();
            return new UnityVector(position);
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