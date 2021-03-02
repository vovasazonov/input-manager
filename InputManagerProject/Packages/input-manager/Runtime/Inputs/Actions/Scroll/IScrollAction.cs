namespace Inputs.Actions.Scroll
{
    public delegate void ScrolledHandler();

    public interface IScrollAction
    {
        event ScrolledHandler Scrolled;
        
        IVector2 ScrollVector { get; }
        float TotalMagnitude { get; }
    }
}