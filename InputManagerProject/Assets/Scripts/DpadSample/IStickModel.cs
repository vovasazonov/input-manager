using System;
using Inputs;

namespace DpadSample
{
    public interface IStickModel
    {
        event Action Moved;
        IVector2 Position { get; }
    }
}