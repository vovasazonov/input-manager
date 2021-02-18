using System;
using UnityEngine.InputSystem;

namespace Inputs.Actions
{
    public sealed class DialogAction : IDialogAction
    {
        private readonly InputAction _inputAction;
        public event Action Addressed;

        public DialogAction(InputAction inputAction)
        {
            _inputAction = inputAction;
            AddInputActionListener();
        }

        private void AddInputActionListener()
        {
            _inputAction.performed += OnPerformed;
        }
        
        private void RemoveInputActionListener()
        {
            _inputAction.performed -= OnPerformed;
        }

        private void OnPerformed(InputAction.CallbackContext inputAction)
        {
            CallAddressed();
        }

        private void CallAddressed()
        {
            Addressed?.Invoke();
        }
    }
}