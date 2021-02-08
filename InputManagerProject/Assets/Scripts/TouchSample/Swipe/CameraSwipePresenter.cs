namespace TouchSample.Swipe
{
    public sealed class CameraSwipePresenter : IPresenter
    {
        private readonly ICameraSwipeView _view;
        private readonly ICameraSwipeModel _model;

        public CameraSwipePresenter(ICameraSwipeView view, ICameraSwipeModel model)
        {
            _view = view;
            _model = model;
        }

        public void Activate()
        {
            _model.Displaced += OnMoved;
        }

        public void Deactivate()
        {
            _model.Displaced -= OnMoved;
        }

        private void OnMoved(float magnitudeX, float magnitudeY)
        {
            _view.DisplaceCamera(magnitudeX, magnitudeY);
        }
    }
}