namespace Inputs.Touches
{
    internal readonly struct SwipeInfo : ISwipeInfo
    {
        public int FingerId { get; }
        public IVector2 StartPosition { get; }
        public IVector2 CurrentPosition { get; }

        public SwipeInfo(int fingerId, IVector2 startPosition, IVector2 currentPosition)
        {
            FingerId = fingerId;
            StartPosition = startPosition;
            CurrentPosition = currentPosition;
        }
    }
}