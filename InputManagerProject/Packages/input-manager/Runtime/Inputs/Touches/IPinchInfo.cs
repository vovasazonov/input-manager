namespace Inputs.Touches
{
    public interface IPinchInfo
    {
        float PinchValue { get; }

        float CurrentMagnitude { get; }

        float TotalMagnitude { get; }
    }
}