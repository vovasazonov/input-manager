namespace Inputs
{
    public interface IVector2
    {
        float X { get; }
        float Y { get; }

        float Distance(IVector2 another);
    }
}