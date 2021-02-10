namespace Inputs
{
    public interface ISwipeInfo
    {
        IVector2 StartPosition { get; }
        IVector2 CurrentPosition { get; }
    }
}