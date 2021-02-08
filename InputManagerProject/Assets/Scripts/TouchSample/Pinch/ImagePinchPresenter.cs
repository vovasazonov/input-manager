namespace TouchSample.Pinch
{
    public class ImagePinchPresenter : IPresenter
    {
        private readonly IImagePinchView _view;
        private readonly IImagePinchModel _model;

        public ImagePinchPresenter(IImagePinchView view, IImagePinchModel model)
        {
            _view = view;
            _model = model;
        }

        public void Activate()
        {
            _model.Scaled += OnScaled;
        }

        public void Deactivate()
        {
            _model.Scaled -= OnScaled;
        }

        private void OnScaled(float delta)
        {
            _view.SetPinch(delta);
        }
    }
}