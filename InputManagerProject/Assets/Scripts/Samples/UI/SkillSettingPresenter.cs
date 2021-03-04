namespace Samples.UI
{
    public sealed class SkillSettingPresenter : IPresenter
    {
        private readonly ISkillModel _model;
        private readonly ISkillSettingView _view;

        public SkillSettingPresenter(ISkillSettingView view, ISkillModel model)
        {
            _view = view;
            _model = model;

            RenderView();
        }

        public void Activate()
        {
            _view.Clicked += OnClicked;
            _model.BindPathChanged += OnBindPathChanged;
        }

        public void Deactivate()
        {
            _view.Clicked -= OnClicked;
            _model.BindPathChanged -= OnBindPathChanged;
        }

        private void RenderView()
        {
            _view.SetNameSkill(_model.NameSkill);
            _view.SetNameBindPath(_model.NameBindPath);
        }

        private void OnBindPathChanged()
        {
            _view.SetNameBindPath(_model.NameBindPath);
        }

        private void OnClicked()
        {
            _model.ChangeBindPath();
        }
    }
}