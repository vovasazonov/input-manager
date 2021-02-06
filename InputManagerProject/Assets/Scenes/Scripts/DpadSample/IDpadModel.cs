using System;
using Inputs;

namespace Scenes.Scripts.DpadSample
{
    public interface IDpadModel
    {
        event Action Moved;
        IVector2 Position { get; }
    }
}