﻿namespace Inputs.Touches
{
    public delegate void SwipeHandler(SwipeInfo swipeInfo);

    public interface ISwipeController
    {
        event SwipeHandler Started;
        event SwipeHandler Proceed;
        event SwipeHandler Stopped;
    }
}