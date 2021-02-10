using Inputs;

namespace Samples
{
    public delegate void ColorChangedHandler(PointColor pointColor);

    public delegate void PositionChangedHandler(IVector2 position);

    public delegate void NumberChangedHandler(int number);

    public interface IPointModel
    {
        event ColorChangedHandler ColorChanged;
        event PositionChangedHandler PositionChanged;
        event NumberChangedHandler NumberChanged;
    }
}