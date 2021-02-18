using System;

namespace Samples.UI
{
    public interface IDialogModel
    {
        event Action Opened;
        event Action Closed;
    }
}