using System;
using Inputs;

namespace TouchSample.Tap
{
    public interface ITapModel
    {
        event Action Tapped;
        IVector2 Position { get; }
        int AmountTap { get; }
    }
}