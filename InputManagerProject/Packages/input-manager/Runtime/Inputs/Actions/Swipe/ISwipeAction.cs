namespace Inputs.Actions.Swipe
{
    public delegate void SwipeHandler(ISwipeInfo swipeInfo);

    public interface ISwipeAction
    {
        event SwipeHandler Proceed;
        event SwipeHandler Started;
        event SwipeHandler Stopped;
    }
}