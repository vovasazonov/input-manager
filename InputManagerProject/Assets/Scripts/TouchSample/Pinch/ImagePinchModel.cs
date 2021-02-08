using Inputs.Touches;

namespace TouchSample.Pinch
{
    public sealed class ImagePinchModel : IImagePinchModel
    {
        private readonly ITouchSystem _touchSystem;
        public event ScaledHandler Scaled;

        public ImagePinchModel(ITouchSystem touchSystem)
        {
            _touchSystem = touchSystem;
            
            AddPinchListener();
        }

        private void AddPinchListener()
        {
            _touchSystem.PinchGesture.Proceed += OnPinched;
        }

        private void RemovePinchListener()
        {
            _touchSystem.PinchGesture.Proceed -= OnPinched;
        }

        private void OnPinched(IPinchInfo pinchInfo)
        {
            CallScaled(pinchInfo.TotalMagnitude);
        }

        private void CallScaled(float delta)
        {
            Scaled?.Invoke(delta);
        }
    }
}