using Inputs.Actions;

namespace Inputs
{
    public interface IPlayerControl : IInputControl
    {
        IMovementAction MovementAction { get; }
        ITapAction TapAction { get; }
        ISwipeAction SwipeAction { get; }
        IDialogAction InventoryDialogAction { get; }
        IDialogAction SkillSettingDialogAction { get; }
        ISkillAction SkillAction1 { get; }
        ISkillAction SkillAction2 { get; }
    }
}