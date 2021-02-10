using UnityEngine;
using UnityEngine.InputSystem;

namespace Inputs
{
    public sealed class ClickAction : IClickAction
    {
        public event ClickedHandler Clicked;
        
        private readonly InputAction _triggerClickAction;
        private readonly InputAction _positionClickAction;
        
        public ClickAction(InputAction triggerClickAction, InputAction positionClickAction)
        {
            _triggerClickAction = triggerClickAction;
            _positionClickAction = positionClickAction;
            
            AddActionListener();
        }

        private void AddActionListener()
        {
            _triggerClickAction.performed += OnActionPreformed;
        }

        private void RemoveActionListener()
        {
            _triggerClickAction.performed -= OnActionPreformed;
        }

        private void OnActionPreformed(InputAction.CallbackContext context)
        {
            var vector = _positionClickAction.ReadValue<Vector2>();
            var screenPosition = new UnityVector(vector);
            CallClicked(screenPosition,0);
        }

        private void CallClicked(IVector2 screenPosition, int amount)
        {
            Clicked?.Invoke(screenPosition, amount);
        }
    }
}