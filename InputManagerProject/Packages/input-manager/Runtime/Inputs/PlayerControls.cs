namespace Inputs
{
    internal sealed class PlayerControls : IPlayerControls
    {
        private readonly PlayerActions _playerActions;
        public IMovement Movement { get; }

        public PlayerControls(PlayerActions playerActions)
        {
            _playerActions = playerActions;
            Movement = new Movement(_playerActions.PlayerControls.Movement);
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