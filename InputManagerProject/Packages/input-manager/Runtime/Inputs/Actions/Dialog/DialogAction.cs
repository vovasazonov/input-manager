using System;
using UnityEngine.InputSystem;

namespace Inputs.Actions.Dialog
{
    internal sealed class DialogAction : IDialogAction
    {
        public event Action Addressed;

        private readonly InputAction _inputAction;

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