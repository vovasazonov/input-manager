using Inputs;

namespace Samples
{
    public delegate void ColorChangedHandler(PointColor pointColor);
    public delegate void PositionChangedHandler(IVector2 position);
    public delegate void NumberChangedHandler(int number);
    public delegate void ScaledHandler(float scale);

    public interface IPointModel
    {
        event ColorChangedHandler ColorChanged;
        event NumberChangedHandler NumberChanged;
        event PositionChangedHandler PositionChanged;
        event ScaledHandler Scaled;
    }
}