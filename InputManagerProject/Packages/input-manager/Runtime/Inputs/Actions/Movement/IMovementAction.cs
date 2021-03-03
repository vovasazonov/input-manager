namespace Inputs.Actions.Movement
{
    public delegate void MovedHandler(IVector2 position);

    public interface IMovementAction
    {
        event MovedHandler Moved;
    }
}