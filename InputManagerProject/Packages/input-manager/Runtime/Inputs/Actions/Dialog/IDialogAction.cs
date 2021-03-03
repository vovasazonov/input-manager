using System;

namespace Inputs.Actions.Dialog
{
    public interface IDialogAction
    {
        event Action Addressed;
    }
}