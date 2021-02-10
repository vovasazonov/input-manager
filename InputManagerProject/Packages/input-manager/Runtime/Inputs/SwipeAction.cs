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
            ChangeModeSwiping();
        }

        private void OnPositionActionPerformed(InputAction.CallbackContext context)
        {
            if (_isSwiping)
            {
                CallProceed(GetSwipeInfo());
            }
        }
        
        private void ChangeModeSwiping()
        {
            if (_isSwiping)
            {
                StopSwiping();
            }
            else
            {
                StartSwiping();
            }
        }

        private void StartSwiping()
        {
            _isSwiping = true;
            InitializeStartScreenPosition();
            CallStarted(GetSwipeInfo());
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