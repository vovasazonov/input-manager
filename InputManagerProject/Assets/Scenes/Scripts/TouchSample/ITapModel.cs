using System;
using Inputs;

namespace Scenes.Scripts.TouchSample
{
    public interface ITapModel
    {
        event Action Tapped;
        IVector2 Position { get; }
        int AmountTap { get; }
    }
}