using System;
using Inputs.Actions;

namespace Samples.UI
{
    public sealed class ActionButtonModel : IActionButtonModel
    {
        private readonly ISkillAction _skillAction;
        public event Action Performed;
        public event Action NameKeyChanged;

        public string NameKey => _skillAction.CurrentBindKey;

        public ActionButtonModel(ISkillAction skillAction)
        {
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
            CallPerformed();
        }

        private void OnRebind()
        {
            CallNameKeyPerformChanged();
        }

        public void ChangeNameKey()
        {
            _skillAction.ChangeBindKey();
        }

        private void CallNameKeyPerformChanged()
        {
            NameKeyChanged?.Invoke();
        }

        private void CallPerformed()
        {
            Performed?.Invoke();
        }
    }
}