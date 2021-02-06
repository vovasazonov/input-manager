namespace Inputs.Dpads
{
    public delegate void MovedHandler();

    public interface IDpad
    {
        event MovedHandler Moved;
        IVector2 Position { get; }
    }
}