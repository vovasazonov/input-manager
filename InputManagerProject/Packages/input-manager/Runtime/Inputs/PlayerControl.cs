namespace Inputs
{
    internal sealed class PlayerControl : IPlayerControl
    {
        private readonly PlayerActions _playerActions;
        public IMovementAction MovementAction { get; }
        public ITapAction TapAction { get; }
        public ISwipeAction SwipeAction { get; }

        public PlayerControl(PlayerActions playerActions)
        {
            _playerActions = playerActions;

            var playerControls = _playerActions.PlayerControls;
            MovementAction = new MovementAction(playerControls.Movement);
            TapAction = new TapAction(playerControls.PointerPosition, playerControls.PointerTap, playerControls.PointerDoubleTap, playerControls.PointerTripleTap);
            SwipeAction = new SwipeAction(playerControls.PointerPosition, playerControls.PointerPressRelease);
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