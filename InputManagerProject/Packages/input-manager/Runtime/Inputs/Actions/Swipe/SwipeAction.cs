using Inputs.BindingComposites;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Inputs.Actions
{
    internal sealed class SwipeAction : ISwipeAction
    {
        public event SwipeHandler Started;
        public event SwipeHandler Proceed;
        public event SwipeHandler Stopped;

        private readonly InputAction _swipeAction;
        private IVector2 _startScreenPosition;
        private bool _isSwiping;
        private bool _isPressing;

        public SwipeAction(InputAction swipeAction)
        {
            _swipeAction = swipeAction;

            AddActionsListeners();
        }

        private void AddActionsListeners()
        {
            _swipeAction.performed += OnPerformed;
            _swipeAction.canceled += OnCanceled;
        }

        private void RemoveActionsListeners()
        {
            _swipeAction.performed -= OnPerformed;
            _swipeAction.canceled -= OnCanceled;
        }

        private void OnPerformed(InputAction.CallbackContext context)
        {
            if (_isSwiping)
            {
                ProceedSwiping();
            }
            else
            {
                DetectStartSwiping();
            }
        }

        private void DetectStartSwiping()
        {
            if (_isPressing)
            {
                StartSwiping();
            }
            else
            {
                _isPressing = true;
            }
        }

        private void OnCanceled(InputAction.CallbackContext context)
        {
            StopSwiping();
        }
        
        private void StartSwiping()
        {
            _isSwiping = true;
            InitializeStartScreenPosition();
            var swipeInfo = GetSwipeInfo();
            CallStarted(swipeInfo);
        }

        private void ProceedSwiping()
        {
            var swipeInfo = GetSwipeInfo();
            CallProceed(swipeInfo);
        }
        
        private void StopSwiping()
        {
            if (_isSwiping)
            {
                _isSwiping = false;
                var swipeInfo = GetSwipeInfo();
                CallStopped(swipeInfo);
            }
            
            _isPressing = false;
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
            var compositeData = _swipeAction.ReadValue<CompositeData>();
            var positionX = compositeData.ReadValue<float>(0);
            var positionY = compositeData.ReadValue<float>(1);
            var vector = new Vector2(positionX, positionY);
            return new UnityVector(vector);
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