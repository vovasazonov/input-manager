using UnityEngine;
using UnityEngine.InputSystem;

namespace Inputs
{
    internal sealed class MovementAction : IMovementAction
    {
        public event MovedHandler Moved;
        
        private readonly InputAction _movementAction;

        private IVector2 Position
        {
            get
            {
                var unityVector = _movementAction.ReadValue<Vector2>();
                return new UnityVector(unityVector);
            }
        }

        public MovementAction(InputAction movementActionAction)
        {
            _movementAction = movementActionAction;
            
            AddMovementActionListener();
        }

        private void AddMovementActionListener()
        {
            _movementAction.performed += OnMovePerformed;
            _movementAction.canceled += OnMoveCanceled;
        }

        private void RemoveMovementListener()
        {
            _movementAction.performed -= OnMovePerformed;
            _movementAction.canceled -= OnMoveCanceled;
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
            Moved?.Invoke(Position);
        }
    }
}