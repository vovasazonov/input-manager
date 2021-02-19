namespace Samples.UI
{
    public sealed class SkillButtonPresenter : IPresenter
    {
        private readonly ISkillButtonView _view;
        private readonly ISkillModel _model;

        public SkillButtonPresenter(ISkillButtonView view, ISkillModel model)
        {
            _view = view;
            _model = model;

            UpdateView();
        }

        private void UpdateView()
        {
            _view.SetNameSkill(_model.NameSkill);
        }

        public void Activate()
        {
            _view.Clicked += OnClicked;
        }

        public void Deactivate()
        {
            _view.Clicked -= OnClicked;
        }

        private void OnClicked()
        {
            _model.Invoke();
        }
    }
}