using Inputs.Actions;
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
    public interface IPlayerControl : IInputControl
    {
        IMovementAction MovementAction { get; }
        ITapAction TapAction { get; }
        ISwipeAction SwipeAction { get; }
        IPinchAction PinchAction { get; }
        IScrollAction ScrollAction { get; }
        IScaleAction ScaleAction { get; }
        IDialogAction InventoryDialogAction { get; }
        IDialogAction SkillSettingDialogAction { get; }
        ISkillAction SkillAction1 { get; }
        ISkillAction SkillAction2 { get; }
    }
}