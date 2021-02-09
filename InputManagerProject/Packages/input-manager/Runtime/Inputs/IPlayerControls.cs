namespace Inputs
{
    public interface IPlayerControls : IInputControl
    {
        IMovement Movement { get; }
    }
}