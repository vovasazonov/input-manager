using UnityEngine;
using UnityEngine.InputSystem;

namespace Inputs.Dpads
{
    public sealed class Dpad : IDpad
    {
        public event MovedHandler Moved;
        
        private readonly InputControls.DpadActions _dpad;

        public IVector2 Position
        {
            get
            {
                var unityVector = _dpad.Move.ReadValue<Vector2>();
                return new CustomVector2(unityVector.x, unityVector.y);
            }
        }

        public Dpad(InputControls.DpadActions dpad)
        {
            _dpad = dpad;
            _dpad.Enable();
            
            AddDpadListener();
        }


        private void AddDpadListener()
        {
            _dpad.Move.performed += OnMovePerformed;
            _dpad.Move.canceled += OnMoveCanceled;
        }

        private void RemoveDpadListener()
        {
            _dpad.Move.performed -= OnMovePerformed;
            _dpad.Move.canceled -= OnMoveCanceled;
        }

        private void OnMoveCanceled(InputAction.CallbackContext context)
        {
            CallMoved();
        }

        private void OnMovePerformed(InputAction.CallbackContext context)
        {
            CallMoved();
        }

        private void CallMoved()
        {
            Moved?.Invoke();
        }
    }
}