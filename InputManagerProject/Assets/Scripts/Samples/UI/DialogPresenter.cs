namespace Samples.UI
{
    public sealed class DialogPresenter : IPresenter
    {
        private readonly IDialogModel _model;
        private readonly IDialogView _view;

        public DialogPresenter(IDialogView view, IDialogModel model)
        {
            _view = view;
            _model = model;
        }

        public void Activate()
        {
            _model.Opened += OnOpened;
            _model.Closed += OnClosed;
        }

        public void Deactivate()
        {
            _model.Opened -= OnOpened;
            _model.Closed -= OnClosed;
        }

        private void OnClosed()
        {
            _view.Close();
        }

        private void OnOpened()
        {
            _view.Open();
        }
    }
}