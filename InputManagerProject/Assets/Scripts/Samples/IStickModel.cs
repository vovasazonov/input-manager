using System;
using Inputs;

namespace Samples
{
    public interface IStickModel
    {
        event Action Moved;
        
        IVector2 Position { get; }
    }
}