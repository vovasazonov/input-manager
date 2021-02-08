namespace TouchSample.Tap
{
    public sealed class TapPresenter : IPresenter
    {
        private readonly ITapView _view;
        private readonly ITapModel _model;

        public TapPresenter(ITapView view, ITapModel model)
        {
            _view = view;
            _model = model;
        }

        private void UpdateView()
        {
            _view.AmountTap = _model.AmountTap;
            _view.Position = _model.Position;
        }

        public void Activate()
        {
            _model.Tapped += OnTapped;
        }

        public void Deactivate()
        {
            _model.Tapped -= OnTapped;
        }

        private void OnTapped()
        {
            UpdateView();
        }
    }
}