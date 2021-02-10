namespace Inputs
{
    public interface IPlayerControl : IInputControl
    {
        IMovementAction MovementAction { get; }
    }
}