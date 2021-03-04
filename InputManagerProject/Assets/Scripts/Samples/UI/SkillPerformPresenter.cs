﻿namespace Samples.UI
{
    public sealed class SkillPerformPresenter : IPresenter
    {
        private readonly ISkillModel _model;
        private readonly ISkillPerformView _view;

        public SkillPerformPresenter(ISkillPerformView view, ISkillModel model)
        {
            _view = view;
            _model = model;
        }

        public void Activate()
        {
            _model.Performed += OnPerformed;
        }

        public void Deactivate()
        {
            _model.Performed -= OnPerformed;
        }

        private void OnPerformed()
        {
            _view.SetNamePerformedSkill(_model.NameSkill);
        }
    }
}