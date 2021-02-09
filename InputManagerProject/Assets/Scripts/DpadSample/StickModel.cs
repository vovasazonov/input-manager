using System;
using Inputs;

namespace DpadSample
{
    public sealed class StickModel : IStickModel
    {
        public event Action Moved;
        
        private readonly IMovement _movement;
        
        public IVector2 Position { get; private set; }

        public StickModel(IMovement movement)
        {
            _movement = movement;
            AddMovementListener();
        }

        private void AddMovementListener()
        {
            _movement.Moved += OnMoved;
        }

        private void RemoveDpadListener()
        {
            _movement.Moved -= OnMoved;
        }

        private void OnMoved(IVector2 position)
        {
            Position = position;
            CallMoved();
        }

        private void CallMoved()
        {
            Moved?.Invoke();
        }
    }
}