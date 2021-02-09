namespace Inputs
{
    public delegate void MovedHandler(IVector2 position);

    public interface IMovement
    {
        event MovedHandler Moved;
    }
}