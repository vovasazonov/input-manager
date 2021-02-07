namespace Inputs.Touches
{
    public interface ITouchSystem
    {
        ITapGesture TapGesture { get; }
        ISwipeGesture SwipeGesture { get; }
    }
}