using System;

namespace Samples.UI
{
    public interface IDialogModel
    {
        event Action Closed;
        event Action Opened;
    }
}