namespace Inputs
{
    internal sealed class PlayerControl : IPlayerControl
    {
        private readonly PlayerActions _playerActions;
        public IMovementAction MovementAction { get; }
        public IClickAction ClickAction { get; }

        public PlayerControl(PlayerActions playerActions)
        {
            _playerActions = playerActions;
            
            MovementAction = new MovementAction(_playerActions.PlayerControls.Movement);
            ClickAction = new ClickAction(_playerActions.PlayerControls.TriggerClick, _playerActions.PlayerControls.PositionClick);
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