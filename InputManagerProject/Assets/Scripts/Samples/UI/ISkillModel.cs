using System;

namespace Samples.UI
{
    public interface ISkillModel
    {
        event Action BindPathChanged;
        event Action Performed;

        string NameSkill { get; }
        string NameBindPath { get; }

        void ChangeBindPath();
        void Invoke();
    }
}