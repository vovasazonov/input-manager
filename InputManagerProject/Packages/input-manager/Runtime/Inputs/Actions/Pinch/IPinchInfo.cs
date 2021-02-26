namespace Inputs.Actions.Pinch
{
    public interface IPinchInfo
    {
        float PinchValue { get; }
        float CurrentMagnitude { get; }
        float TotalMagnitude { get; }
    }
}