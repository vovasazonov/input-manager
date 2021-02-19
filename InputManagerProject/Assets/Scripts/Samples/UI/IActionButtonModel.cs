using System;

namespace Samples.UI
{
    public interface IActionButtonModel
    {
        event Action Performed;
        event Action NameKeyChanged;
        
        string NameKey { get; }

        void ChangeNameKey();
    }
}