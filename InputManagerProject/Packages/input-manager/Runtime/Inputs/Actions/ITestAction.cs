using UnityEngine;
using UnityEngine.InputSystem;

namespace Inputs.Actions
{
    public interface ITestAction
    {
        
    }

    public sealed class TestAction : ITestAction
    {
        private readonly InputAction _inputAction;

        public TestAction(InputAction inputAction)
        {
            _inputAction = inputAction;
            AddActionListener();
        }
        
        private void AddActionListener()
        {
            _inputAction.performed += OnActionPreformed;
        }

        private void RemoveActionListener()
        {
            _inputAction.performed -= OnActionPreformed;
        }

        private void OnActionPreformed(InputAction.CallbackContext obj)
        {
            Debug.Log("test performed");
        }
    }
}