using Inputs;

namespace TouchSample.Tap
{
    public interface ITapView
    {
        IVector2 Position { set; }
        int AmountTap { set; }
    }
}