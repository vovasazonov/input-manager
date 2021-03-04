namespace Inputs.Actions.Pinch
{
    public delegate void PinchHandler(IPinchInfo pinchInfo);

    public interface IPinchAction
    {
        event PinchHandler Proceed;
        event PinchHandler Started;
        event PinchHandler Stopped;
    }
}