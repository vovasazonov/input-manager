using System;

namespace Samples.UI
{
    public interface IActionButtonView
    {
        event Action Clicked;

        void SetNameKey(string nameKey);
    }
}