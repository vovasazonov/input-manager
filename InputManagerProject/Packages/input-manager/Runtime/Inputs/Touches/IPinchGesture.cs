namespace Inputs.Touches
{
    public delegate void PinchHandler(IPinchInfo pinchInfo);

    public interface IPinchGesture
    {
        event PinchHandler Started;
        event PinchHandler Proceed;
        event PinchHandler Stopped;
    }
}