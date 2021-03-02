using Inputs.Actions;
using Inputs.Actions.Pinch;
using Inputs.Actions.Scroll;

namespace Inputs
{
    public interface IPlayerControl : IInputControl
    {
        IMovementAction MovementAction { get; }
        ITapAction TapAction { get; }
        ISwipeAction SwipeAction { get; }
        IPinchAction PinchAction { get; }
        IScrollAction ScrollAction { get; }
        IDialogAction InventoryDialogAction { get; }
        IDialogAction SkillSettingDialogAction { get; }
        ISkillAction SkillAction1 { get; }
        ISkillAction SkillAction2 { get; }
    }
}