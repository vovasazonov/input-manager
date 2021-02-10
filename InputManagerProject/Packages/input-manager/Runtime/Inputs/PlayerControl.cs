namespace Inputs
{
    internal sealed class PlayerControl : IPlayerControl
    {
        private readonly PlayerActions _playerActions;
        public IMovementAction MovementAction { get; }

        public PlayerControl(PlayerActions playerActions)
        {
            _playerActions = playerActions;
            MovementAction = new MovementAction(_playerActions.PlayerControls.Movement);
        }

        public void Activate()
        {
            _playerActions.PlayerControls.Enable();
        }

        public void Deactivate()
        {
            _playerActions.PlayerControls.Disable();
        }
    }
}