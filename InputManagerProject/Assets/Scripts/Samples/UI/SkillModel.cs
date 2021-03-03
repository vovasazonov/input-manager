using System;
using Inputs.Actions;
using Inputs.Actions.Skill;

namespace Samples.UI
{
    public sealed class SkillModel : ISkillModel
    {
        private readonly ISkillAction _skillAction;
        public event Action Performed;
        public event Action BindPathChanged;

        public string NameSkill { get; }
        public string NameBindPath => _skillAction.CurrentBindPath;

        public SkillModel(ISkillAction skillAction, string nameSkill)
        {
            NameSkill = nameSkill;
            _skillAction = skillAction;
            AddActionListener();
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

        public void ChangeBindPath()
        {
            _skillAction.ChangeBindPath();
        }

        public void Invoke()
        {
            CallPerformed();
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