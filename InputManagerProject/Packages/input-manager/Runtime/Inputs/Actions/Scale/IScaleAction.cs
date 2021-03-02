namespace Inputs.Actions.Scale
{
    public delegate void ScaledHandler();

    public interface IScaleAction
    {
        event ScaledHandler Scaled;

        float TotalMagnitude { get; }
    }
}