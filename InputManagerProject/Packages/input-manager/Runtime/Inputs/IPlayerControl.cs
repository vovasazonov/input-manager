using Inputs.Actions;

namespace Inputs
{
    public interface IPlayerControl : IInputControl
    {
        IMovementAction MovementAction { get; }
        ITapAction TapAction { get; }
        ISwipeAction SwipeAction { get; }
        IDialogAction InventoryDialogAction { get; }
    }
}