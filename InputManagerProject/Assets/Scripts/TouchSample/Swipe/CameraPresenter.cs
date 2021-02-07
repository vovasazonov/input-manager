using Inputs.Touches;

namespace Scenes.Scripts.TouchSample.Swipe
{
    public sealed class CameraPresenter : IPresenter
    {
        private readonly ICameraView _view;
        private readonly ICameraModel _model;

        public CameraPresenter(ICameraView view, ICameraModel model)
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

        private void OnMoved(float deltaX, float deltaY)
        {
            _view.SetPositionFromDefault(deltaX, deltaY);
        }
    }
}