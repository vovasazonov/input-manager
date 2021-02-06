using System;
using Inputs;
using Inputs.Touches;

namespace Scenes.Scripts.TouchSample
{
    public sealed class TapModel : ITapModel
    {
        public event Action Tapped;
        
        private readonly ITapController _tapController;
        public IVector2 Position { get; private set; }
        public int AmountTap { get; private set; }
        
        public TapModel(ITapController tapController)
        {
            _tapController = tapController;
            AddTapListener();
        }

        private void AddTapListener()
        {
            _tapController.Tapped += OnTapped;
        }

        private void RemoveTapListener()
        {
            _tapController.Tapped -= OnTapped;
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