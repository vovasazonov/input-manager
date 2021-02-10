namespace Samples
{
    public class StickCoordinatesPresenter : IPresenter
    {
        private readonly ICoordinatesView _view;
        private readonly IStickModel _model;

        public StickCoordinatesPresenter(ICoordinatesView view, IStickModel model)
        {
            _view = view;
            _model = model;
        }

        public void Activate()
        {
            _model.Moved += OnMoved;
        }

        public void Deactivate()
        {
            _model.Moved -= OnMoved;
        }

        private void OnMoved()
        {
            UpdateView();
        }

        private void UpdateView()
        {
            var position = _model.Position;
            _view.X = $"{position.X:f4}";
            _view.Y = $"{position.Y:f4}";
        }
    }
}