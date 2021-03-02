namespace Inputs.Actions.Scale
{
    public delegate void PerformedHandler();

    public interface IScaleAction
    {
        event PerformedHandler Performed;

        float TotalMagnitude { get; }
    }
}