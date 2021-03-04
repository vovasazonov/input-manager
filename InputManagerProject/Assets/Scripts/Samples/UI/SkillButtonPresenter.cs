namespace Samples.UI
{
    public sealed class SkillButtonPresenter : IPresenter
    {
        private readonly ISkillModel _model;
        private readonly ISkillButtonView _view;

        public SkillButtonPresenter(ISkillButtonView view, ISkillModel model)
        {
            _view = view;
            _model = model;

            UpdateView();
        }

        public void Activate()
        {
            _view.Clicked += OnClicked;
        }

        public void Deactivate()
        {
            _view.Clicked -= OnClicked;
        }

        private void UpdateView()
        {
            _view.SetNameSkill(_model.NameSkill);
        }

        private void OnClicked()
        {
            _model.Invoke();
        }
    }
}