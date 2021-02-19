using System;

namespace Inputs
{
    public interface IDialogAction
    {
        event Action Addressed;
    }
}