namespace Samples.UI
{
    public sealed class ActionButtonPresenter : IPresenter
    {
        private readonly IActionButtonView _view;
        private readonly IActionButtonModel _model;

        public ActionButtonPresenter(IActionButtonView view, IActionButtonModel model)
        {
            _view = view;
            _model = model;

            UpdateView();
        }

        private void UpdateView()
        {
            UpdateName();
        }

        public void Activate()
        {
            _model.NameKeyChanged += OnNameKeyChanged;
            _view.Clicked += OnClicked;
        }

        public void Deactivate()
        {
            _model.NameKeyChanged -= OnNameKeyChanged;
            _view.Clicked -= OnClicked;
        }

        private void OnClicked()
        {
            _model.ChangeNameKey();
        }

        private void OnNameKeyChanged()
        {
            UpdateName();
        }

        void UpdateName()
        {
            _view.SetNameKey(_model.NameKey);
        }
    }
}