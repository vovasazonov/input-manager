using Inputs.Actions.Pinch;
using Inputs.Actions.Scroll;

namespace Inputs.Actions.Scale
{
    public sealed class ScaleAction : IScaleAction
    {
        public event PerformedHandler Performed;

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
            _scrollAction.Performed += OnScrollPerformed;
        }

        private void RemoveScrollListeners()
        {
            _scrollAction.Performed -= OnScrollPerformed;
        }

        private void OnScrollPerformed()
        {
            TotalMagnitude = _scrollAction.TotalMagnitude;
            CallPerformed();
        }
        
        private void OnPinchProceed(IPinchInfo pinchInfo)
        {
            TotalMagnitude = pinchInfo.TotalMagnitude;
            CallPerformed();
        }

        private void CallPerformed()
        {
            Performed?.Invoke();
        }
    }
}