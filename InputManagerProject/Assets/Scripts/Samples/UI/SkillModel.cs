using System;
using Inputs.Actions.Skill;

namespace Samples.UI
{
    public sealed class SkillModel : ISkillModel
    {
        public event Action BindPathChanged;
        public event Action Performed;

        private readonly ISkillAction _skillAction;

        public string NameSkill { get; }
        public string NameBindPath => _skillAction.CurrentBindPath;

        public SkillModel(ISkillAction skillAction, string nameSkill)
        {
            NameSkill = nameSkill;
            _skillAction = skillAction;
            AddActionListener();
        }

        public void ChangeBindPath()
        {
            _skillAction.ChangeBindPath();
        }

        public void Invoke()
        {
            CallPerformed();
        }

        private void AddActionListener()
        {
            _skillAction.Performed += OnSkillPerformed;
            _skillAction.Rebind += OnRebind;
        }

        private void RemoveActionListener()
        {
            _skillAction.Performed -= OnSkillPerformed;
            _skillAction.Rebind -= OnRebind;
        }

        private void OnSkillPerformed()
        {
            Invoke();
        }

        private void OnRebind()
        {
            CallNameKeyPerformChanged();
        }

        private void CallNameKeyPerformChanged()
        {
            BindPathChanged?.Invoke();
        }

        private void CallPerformed()
        {
            Performed?.Invoke();
        }
    }
}