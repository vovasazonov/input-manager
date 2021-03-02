using System;

namespace Inputs.Actions.Scroll
{
    public delegate void PerformedHandler();

    public interface IScrollAction
    {
        event PerformedHandler Performed;
        
        IVector2 ScrollVector { get; }
        float TotalMagnitude { get; }
    }
}