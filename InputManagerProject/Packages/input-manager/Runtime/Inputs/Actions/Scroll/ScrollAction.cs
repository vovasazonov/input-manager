using UnityEngine;
using UnityEngine.InputSystem;

namespace Inputs.Actions.Scroll
{
    public sealed class ScrollAction : IScrollAction
    {
        public event ScrolledHandler Scrolled;
        
        private readonly InputAction _inputAction;
        private Vector2 _scrollVector2;

        public IVector2 ScrollVector => new UnityVector(_scrollVector2);
        public float TotalMagnitude => Vector2.zero.magnitude + _scrollVector2.magnitude;

        public ScrollAction(InputAction inputAction)
        {
            _inputAction = inputAction;
            
            AddInputActionListeners();
        }

        private void AddInputActionListeners()
        {
            _inputAction.performed += OnPerformed;
            _inputAction.canceled += OnCanceled;
        }

        private void RemoveInputActionListeners()
        {
            _inputAction.performed += OnPerformed;
            _inputAction.canceled += OnCanceled;
        }

        private void OnCanceled(InputAction.CallbackContext context)
        {
            _scrollVector2 = Vector2.zero;
        }

        private void OnPerformed(InputAction.CallbackContext context)
        {
            _scrollVector2 = _inputAction.ReadValue<Vector2>();
            CallScrolled();
        }

        private void CallScrolled()
        {
            Scrolled?.Invoke();
        }
    }
}