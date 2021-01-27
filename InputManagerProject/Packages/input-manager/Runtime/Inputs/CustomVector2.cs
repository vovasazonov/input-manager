namespace Inputs
{
    internal readonly struct CustomVector2 : IVector2
    {
        public float X { get; }
        public float Y { get; }

        public CustomVector2(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}