namespace Scenes.Scripts.TouchSample.Swipe
{
    public sealed class CameraSwipePresenter : IPresenter
    {
        private readonly ICameraSwipeView _swipeView;
        private readonly ICameraSwipeModel _swipeModel;

        public CameraSwipePresenter(ICameraSwipeView swipeView, ICameraSwipeModel swipeModel)
        {
            _swipeView = swipeView;
            _swipeModel = swipeModel;
        }

        public void Activate()
        {
            _swipeModel.Moved += OnMoved;
        }

        public void Deactivate()
        {
            _swipeModel.Moved -= OnMoved;
        }

        private void OnMoved(float deltaX, float deltaY)
        {
            _swipeView.SetPositionFromDefault(deltaX, deltaY);
        }
    }
}