using System;
using Inputs;
using Inputs.Dpads;

namespace DpadSample
{
    public sealed class DpadModel : IDpadModel
    {
        public event Action Moved;
        
        private readonly IDpad _dpad;
        public IVector2 Position => _dpad.Position;

        public DpadModel(IDpad dpad)
        {
            _dpad = dpad;
            AddDpadListener();
        }

        private void AddDpadListener()
        {
            _dpad.Moved += OnMoved;
        }

        private void RemoveDpadListener()
        {
            _dpad.Moved -= OnMoved;
        }

        private void OnMoved()
        {
            CallMoved();
        }

        private void CallMoved()
        {
            Moved?.Invoke();
        }
    }
}