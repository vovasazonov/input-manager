using Inputs.BindingComposites;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Inputs.Actions.Pinch
{
    internal sealed class PinchAction : IPinchAction
    {
        public event PinchHandler Started;
        public event PinchHandler Proceed;
        public event PinchHandler Stopped;

        private readonly InputAction _pinchAction;
        private bool _isPinch;
        private float _startMagnitude;
        private PinchInfo _pinchInfo;

        public PinchAction(InputAction pinchAction)
        {
            _pinchAction = pinchAction;
            AddActionListeners();
        }

        private void AddActionListeners()
        {
            _pinchAction.started += OnActionStarted;
            _pinchAction.performed += OnActionPerformed;
            _pinchAction.canceled += OnActionCanceled;
        }

        private void RemoveActionListeners()
        {
            _pinchAction.started -= OnActionStarted;
            _pinchAction.performed -= OnActionPerformed;
            _pinchAction.canceled -= OnActionCanceled;
        }

        private void OnActionStarted(InputAction.CallbackContext context)
        {
            GeneratePinchInfo(context);
            _isPinch = true;
            
            CallStarted(_pinchInfo);
        }

        private void OnActionCanceled(InputAction.CallbackContext context)
        {
            _isPinch = false;

            CallStopped(_pinchInfo);
        }

        private void OnActionPerformed(InputAction.CallbackContext context)
        {
            GeneratePinchInfo(context);

            CallProceed(_pinchInfo);
        }

        private void GeneratePinchInfo(InputAction.CallbackContext context)
        {
            var compositeData = context.ReadValue<CompositeData>();
            
            var xPositionFinger0 = compositeData.ReadValue<float>(0);
            var yPositionFinger0 = compositeData.ReadValue<float>(1);
            var xPositionFinger1 = compositeData.ReadValue<float>(2);
            var yPositionFinger1 = compositeData.ReadValue<float>(3);
            var positionFinger0 = new UnityVector(new Vector2(xPositionFinger0, yPositionFinger0));
            var positionFinger1 = new UnityVector(new Vector2(xPositionFinger1, yPositionFinger1));

            if (!_isPinch)
            {
                _startMagnitude = positionFinger0.Distance(positionFinger1);
            }
            
            _pinchInfo =  new PinchInfo(_startMagnitude, positionFinger0, positionFinger1);
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