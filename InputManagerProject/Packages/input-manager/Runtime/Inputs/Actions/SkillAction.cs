using System;
using System.Linq;
using UnityEngine.InputSystem;

namespace Inputs.Actions
{
    internal sealed class SkillAction : ISkillAction
    {
        public event Action Performed;
        public event Action Rebind;

        private readonly InputAction _inputAction;
        private InputActionRebindingExtensions.RebindingOperation _rebindOperation;

        public string CurrentBindPath => _inputAction.bindings.First().effectivePath;

        public SkillAction(InputAction inputAction)
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

        private void OnPerformed(InputAction.CallbackContext context)
        {
            CallPerformed();
        }

        public void ChangeBindPath()
        {
            StartRebind();
        }

        private void StartRebind()
        {
            _inputAction.Disable();
            _rebindOperation = _inputAction.PerformInteractiveRebinding()
                .WithControlsExcluding("<Mouse>/position")
                .WithControlsExcluding("<Mouse>/delta")
                .WithControlsExcluding("<Gamepad>/Start")
                .WithControlsExcluding("<Keyboard>/p")
                .WithControlsExcluding("<Keyboard>/escape")
                .OnMatchWaitForAnother(0.1f)
                .OnComplete(operation => RebindCompleted());

            _rebindOperation.Start();
        }

        private void RebindCompleted()
        {
            _rebindOperation.Dispose();
            _rebindOperation = null;
            _inputAction.Enable();
            CallRebind();
        }

        private void CallRebind()
        {
            Rebind?.Invoke();
        }

        private void CallPerformed()
        {
            Performed?.Invoke();
        }
    }
}