namespace Inputs.Touches
{
    public delegate void SwipeHandler(ISwipeInfo swipeInfo);

    public interface ISwipeGesture
    {
        event SwipeHandler Started;
        event SwipeHandler Proceed;
        event SwipeHandler Stopped;
    }
}