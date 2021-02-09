using UnityEngine;

namespace Inputs
{
    internal readonly struct UnityVector : IVector2
    {
        private readonly Vector2 _vector2;

        public float X => _vector2.x;
        public float Y => _vector2.y;

        public UnityVector(Vector2 vector2)
        {
            _vector2 = vector2;
        }

        public float Distance(IVector2 another)
        {
            var anotherVector2 = new Vector2(another.X, another.Y);
            return Vector2.Distance(_vector2, anotherVector2);
        }
    }
}