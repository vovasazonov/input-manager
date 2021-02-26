namespace Inputs.Actions.Pinch
{
    public delegate void PinchHandler(PinchInfo pinchInfo);

    public interface IPinchAction
    {
        event PinchHandler Started;
        event PinchHandler Proceed;
        event PinchHandler Stopped;
    }
}