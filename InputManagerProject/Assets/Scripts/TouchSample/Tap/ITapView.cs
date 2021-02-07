using Inputs;

namespace Scenes.Scripts.TouchSample
{
    public interface ITapView
    {
        IVector2 Position { set; }
        int AmountTap { set; }
    }
}