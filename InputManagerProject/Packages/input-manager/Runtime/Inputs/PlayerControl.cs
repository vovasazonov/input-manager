using Inputs.Actions.Dialog;
using Inputs.Actions.Movement;
using Inputs.Actions.Pinch;
using Inputs.Actions.Scale;
using Inputs.Actions.Scroll;
using Inputs.Actions.Skill;
using Inputs.Actions.Swipe;
using Inputs.Actions.Tap;

namespace Inputs
{
    internal sealed class PlayerControl : IPlayerControl
    {
        private readonly PlayerActions _playerActions;

        public IMovementAction MovementAction { get; }
        public ITapAction TapAction { get; }
        public ISwipeAction SwipeAction { get; }
        public IPinchAction PinchAction { get; }
        public IScrollAction ScrollAction { get; }
        public IScaleAction ScaleAction { get; }
        public IDialogAction InventoryDialogAction { get; }
        public IDialogAction SkillSettingDialogAction { get; }
        public ISkillAction SkillAction1 { get; }
        public ISkillAction SkillAction2 { get; }

        public PlayerControl(PlayerActions playerActions)
        {
            _playerActions = playerActions;
            var playerControls = _playerActions.PlayerControls;

            MovementAction = new MovementAction(playerControls.Movement);
            TapAction = new TapAction(playerControls.Tap);
            SwipeAction = new SwipeAction(playerControls.Swipe);
            PinchAction = new PinchAction(playerControls.Pinch);
            ScrollAction = new ScrollAction(playerControls.Scroll);
            ScaleAction = new ScaleAction(PinchAction, ScrollAction);
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