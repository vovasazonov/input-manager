namespace Inputs.Touches
{
    public interface ISwipeInfo
    {
        int FingerId { get; }
        IVector2 StartPosition { get; }
        IVector2 CurrentPosition { get; }
    }
}