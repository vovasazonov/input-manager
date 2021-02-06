namespace Scenes.Scripts.TouchSample
{
    public sealed class TapPresenter
    {
        private readonly ITapView _view;
        private readonly ITapModel _model;

        public TapPresenter(ITapView view, ITapModel model)
        {
            _view = view;
            _model = model;
        }

        public void Update()
        {
            _view.AmountTap = _model.AmountTap;
            _view.IsTap = _model.IsTap;
        }
    }
}