namespace Inputs
{
    public delegate void ClickedHandler(IVector2 screenPosition, int amount);

    public interface ITapAction
    {
        event ClickedHandler Clicked;
    }
}