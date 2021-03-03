using System;
using Inputs.Actions;
using Inputs.Actions.Dialog;

namespace Samples.UI
{
    public sealed class DialogModel : IDialogModel
    {
        private readonly IDialogAction _dialogAction;
        public event Action Opened;
        public event Action Closed;

        private bool _isOpen;
        
        public DialogModel(IDialogAction dialogAction)
        {
            _dialogAction = dialogAction;
            AddDialogListener();
        }

        private void AddDialogListener()
        {
            _dialogAction.Addressed += OnAddressed;
        }
        
        private void RemoveInventoryDialogListener()
        {
            _dialogAction.Addressed -= OnAddressed;
        }

        private void OnAddressed()
        {
            _isOpen = !_isOpen;

            if (_isOpen)
            {
                CallOpened();
            }
            else
            {
                CallClosed();
            }
        }

        private void CallOpened()
        {
            Opened?.Invoke();
        }

        private void CallClosed()
        {
            Closed?.Invoke();
        }
    }
}