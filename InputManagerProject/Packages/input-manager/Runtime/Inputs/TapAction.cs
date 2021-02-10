using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

namespace Inputs
{
    public sealed class TapAction : ITapAction
    {
        public event ClickedHandler Clicked;

        private readonly InputAction[] _tapActions;
        private readonly InputAction _primaryPointerPositionAction;

        public TapAction(InputAction primaryPointerPositionAction, params InputAction[] tapActions)
        {
            _primaryPointerPositionAction = primaryPointerPositionAction;
            _tapActions = tapActions;

            AddActionListener();
        }

        private void AddActionListener()
        {
            foreach (var tapAction in _tapActions)
            {
                tapAction.performed += OnActionPreformed;
            }
        }

        private void RemoveActionListener()
        {
            foreach (var tapAction in _tapActions)
            {
                tapAction.performed -= OnActionPreformed;
            }
        }

        private void OnActionPreformed(InputAction.CallbackContext context)
        {
            var vector = _primaryPointerPositionAction.ReadValue<Vector2>();
            var screenPosition = new UnityVector(vector);

            if (context.interaction is MultiTapInteraction interaction)
            {
                var tapCount = interaction.tapCount;
                CallClicked(screenPosition, tapCount);
            }
        }

        private void CallClicked(IVector2 screenPosition, int amount)
        {
            Clicked?.Invoke(screenPosition, amount);
        }
    }
}