using UnityEngine;

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

        public CustomVector2(Vector2 vector2)
        {
            X = vector2.x;
            Y = vector2.y;
        }
    }
}