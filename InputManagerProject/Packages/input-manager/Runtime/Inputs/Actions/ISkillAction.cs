using System;

namespace Inputs.Actions
{
    public interface ISkillAction
    {
        event Action Performed;
        event Action Rebind;
        
        string CurrentBindKey { get; }
        
        void ChangeBindKey();
    }
}