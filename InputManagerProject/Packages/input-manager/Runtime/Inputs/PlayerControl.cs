using Inputs.Actions;

namespace Inputs
{
    internal sealed class PlayerControl : IPlayerControl
    {
        private readonly PlayerActions _playerActions;
        public IMovementAction MovementAction { get; }
        public ITapAction TapAction { get; }
        public ISwipeAction SwipeAction { get; }
        public IDialogAction InventoryDialogAction { get; }
        public IDialogAction SkillSettingDialogAction { get; }
        public ISkillAction SkillAction1 { get; }
        public ISkillAction SkillAction2 { get; }

        public PlayerControl(PlayerActions playerActions)
        {
            _playerActions = playerActions;

            var playerControls = _playerActions.PlayerControls;
            MovementAction = new MovementAction(playerControls.Movement);
            TapAction = new TapAction(playerControls.PointerPosition, playerControls.PointerTap, playerControls.PointerDoubleTap, playerControls.PointerTripleTap);
            SwipeAction = new SwipeAction(playerControls.PointerPosition, playerControls.PointerPressRelease);
            InventoryDialogAction = new DialogAction(playerControls.InventoryDialog);
            SkillSettingDialogAction = new DialogAction(playerControls.SettingSkillDialog);
            SkillAction1 = new SkillAction(playerControls.SkillButton1);
            SkillAction2 = new SkillAction(playerControls.SkillButton2);
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