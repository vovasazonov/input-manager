namespace Inputs.Actions.Swipe
{
    internal readonly struct SwipeInfo : ISwipeInfo
    {
        public IVector2 StartPosition { get; }
        public IVector2 CurrentPosition { get; }

        public SwipeInfo(IVector2 startPosition, IVector2 currentPosition)
        {
            StartPosition = startPosition;
            CurrentPosition = currentPosition;
        }
    }
}