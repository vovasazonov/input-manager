using System;

namespace Inputs.Actions
{
    public interface IDialogAction
    {
        event Action Addressed;
    }
}