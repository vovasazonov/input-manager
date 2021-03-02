﻿using Inputs;

namespace Samples
{
    public interface IPointView
    {
        void SetPosition(IVector2 position);
        void SetNumber(int amount);
        void SetColor(PointColor pointColor);
        void ChangeScale(float magnitudeDelta);
    }

    public enum PointColor
    {
        Red,
        Blue,
        Green
    }
}