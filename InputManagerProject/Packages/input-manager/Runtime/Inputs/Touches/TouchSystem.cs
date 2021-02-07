using UnityEngine.InputSystem.EnhancedTouch;

namespace Inputs.Touches
{
    internal sealed class TouchSystem : ITouchSystem
    {
        public ITapGesture TapGesture { get; }
        public ISwipeGesture SwipeGesture { get; }
        
        public TouchSystem()
        {
            EnhancedTouchSupport.Enable();
            
            TapGesture = new TapGesture();
            SwipeGesture = new SwipeGesture();
        }
    }
}