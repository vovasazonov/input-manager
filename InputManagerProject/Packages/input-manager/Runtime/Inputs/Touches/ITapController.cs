namespace Inputs.Touches
{
    public delegate void TappedHandler(IVector2 screenPosition, int amountTap);

    public interface ITapController
    {
        event TappedHandler Tapped;
    }
}