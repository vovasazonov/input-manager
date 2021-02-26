namespace Inputs.Actions
{
    public delegate void SwipeHandler(ISwipeInfo swipeInfo);

    public interface ISwipeAction
    {
        event SwipeHandler Started;
        event SwipeHandler Proceed;
        event SwipeHandler Stopped;
    }
}