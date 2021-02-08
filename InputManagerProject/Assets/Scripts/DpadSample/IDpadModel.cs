using System;
using Inputs;

namespace DpadSample
{
    public interface IDpadModel
    {
        event Action Moved;
        IVector2 Position { get; }
    }
}