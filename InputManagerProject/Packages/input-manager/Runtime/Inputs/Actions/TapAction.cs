using Inputs.BindingComposites;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Inputs.Actions
{
    public sealed class TapAction : ITapAction
    {
        public event TappedHandler Tapped;

        private readonly InputAction _tapAction;

        public TapAction(InputAction tapAction)
        {
            _tapAction = tapAction;

            AddActionListener();
        }

        private void AddActionListener()
        {
            _tapAction.performed += OnActionPreformed;
        }

        private void RemoveActionListener()
        {
            _tapAction.performed -= OnActionPreformed;
        }

        private void OnActionPreformed(InputAction.CallbackContext context)
        {
            var compositeData = context.ReadValue<CompositeData>();
            var tapCount = compositeData.ReadValue<int>(2);

            if (tapCount > 0)
            {
                var positionX = compositeData.ReadValue<float>(0);
                var positionY = compositeData.ReadValue<float>(1);
                var vector = new Vector2(positionX, positionY);
                IVector2 position = new UnityVector(vector);
                
                CallClicked(position, tapCount);
            }
        }

        private void CallClicked(IVector2 screenPosition, int amount)
        {
            Tapped?.Invoke(screenPosition, amount);
        }
    }
}