using System;

namespace Inputs.Actions
{
    public interface ISkillAction
    {
        event Action Performed;
        event Action Rebind;
        
        string CurrentBindPath { get; }
        
        void ChangeBindPath();
    }
}