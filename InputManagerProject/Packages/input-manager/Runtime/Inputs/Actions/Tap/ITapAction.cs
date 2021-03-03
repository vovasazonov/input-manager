namespace Inputs.Actions.Tap
{
    public delegate void TappedHandler(IVector2 screenPosition, int amount);

    public interface ITapAction
    {
        event TappedHandler Tapped;
    }
}