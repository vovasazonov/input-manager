using UnityEngine;
using UnityEngine.InputSystem;

namespace Inputs.Actions.Movement
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

            AddActionListener();
        }

        private void AddActionListener()
        {
            _movementAction.performed += OnActionPerformed;
            _movementAction.canceled += OnActionCanceled;
        }

        private void RemoveMovementListener()
        {
            _movementAction.performed -= OnActionPerformed;
            _movementAction.canceled -= OnActionCanceled;
        }

        private void OnActionCanceled(InputAction.CallbackContext context)
        {
            CallMoved();
        }

        private void OnActionPerformed(InputAction.CallbackContext context)
        {
            CallMoved();
        }

        private void CallMoved()
        {
            Moved?.Invoke(Position);
        }
    }
}