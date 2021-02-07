namespace Inputs.Touches
{
    public interface ITouchSystem
    {
        ITapController TapController { get; }
        ISwipeController SwipeController { get; }
    }
}