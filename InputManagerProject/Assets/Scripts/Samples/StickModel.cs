using System;
using Inputs;
using Inputs.Actions.Movement;

namespace Samples
{
    public sealed class StickModel : IStickModel
    {
        public event Action Moved;

        private readonly IMovementAction _movementAction;

        public IVector2 Position { get; private set; }

        public StickModel(IMovementAction movementAction)
        {
            _movementAction = movementAction;
            AddMovementListener();
        }

        private void AddMovementListener()
        {
            _movementAction.Moved += OnMoved;
        }

        private void RemoveDpadListener()
        {
            _movementAction.Moved -= OnMoved;
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