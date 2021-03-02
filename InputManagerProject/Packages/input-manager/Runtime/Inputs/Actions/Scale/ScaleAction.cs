using Inputs.Actions.Pinch;
using Inputs.Actions.Scroll;

namespace Inputs.Actions.Scale
{
    public sealed class ScaleAction : IScaleAction
    {
        public event ScaledHandler Scaled;

        private readonly IPinchAction _pinchAction;
        private readonly IScrollAction _scrollAction;

        public float TotalMagnitude { get; private set; }

        public ScaleAction(IPinchAction pinchAction, IScrollAction scrollAction)
        {
            _pinchAction = pinchAction;
            _scrollAction = scrollAction;
            
            AddPinchListeners();
            AddScrollListeners();
        }

        private void AddPinchListeners()
        {
            _pinchAction.Proceed += OnPinchProceed;
        }

        private void RemovePinchListeners()
        {
            _pinchAction.Proceed -= OnPinchProceed;
        }

        private void AddScrollListeners()
        {
            _scrollAction.Scrolled += OnScrollScrolled;
        }

        private void RemoveScrollListeners()
        {
            _scrollAction.Scrolled -= OnScrollScrolled;
        }

        private void OnScrollScrolled()
        {
            TotalMagnitude = _scrollAction.TotalMagnitude;
            CallScaled();
        }
        
        private void OnPinchProceed(IPinchInfo pinchInfo)
        {
            TotalMagnitude = pinchInfo.TotalMagnitude;
            CallScaled();
        }

        private void CallScaled()
        {
            Scaled?.Invoke();
        }
    }
}