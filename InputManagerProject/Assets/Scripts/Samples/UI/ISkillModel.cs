using System;

namespace Samples.UI
{
    public interface ISkillModel
    {
        event Action Performed;
        event Action BindPathChanged;

        string NameSkill { get; }
        string NameBindPath { get; }

        void ChangeBindPath();
        void Invoke();
    }
}