namespace Inputs.Actions
{
    public delegate void MovedHandler(IVector2 position);

    public interface IMovementAction
    {
        event MovedHandler Moved;
    }
}