using System;
using Inputs;
using Inputs.Touches;

namespace TouchSample.Tap
{
    public sealed class TapModel : ITapModel
    {
        public event Action Tapped;
        
        private readonly ITapGesture _tapGesture;
        public IVector2 Position { get; private set; }
        public int AmountTap { get; private set; }
        
        public TapModel(ITapGesture tapGesture)
        {
            _tapGesture = tapGesture;
            AddTapListener();
        }

        private void AddTapListener()
        {
            _tapGesture.Tapped += OnTapped;
        }

        private void RemoveTapListener()
        {
            _tapGesture.Tapped -= OnTapped;
        }
        
        private void OnTapped(IVector2 screenPosition, int amountTap)
        {
            Position = screenPosition;
            AmountTap = amountTap;
            
            CallTapped();
        }

        private void CallTapped()
        {
            Tapped?.Invoke();
        }
    }
}