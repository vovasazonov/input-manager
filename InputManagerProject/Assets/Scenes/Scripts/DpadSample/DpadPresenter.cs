namespace Scenes.Scripts.DpadSample
{
    public class DpadPresenter : IPresenter
    {
        private readonly IDpadCoordinatesView _view;
        private readonly IDpadModel _model;

        public DpadPresenter(IDpadCoordinatesView view, IDpadModel model)
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