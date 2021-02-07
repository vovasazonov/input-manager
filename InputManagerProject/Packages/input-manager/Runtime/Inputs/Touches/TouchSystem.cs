using UnityEngine.InputSystem.EnhancedTouch;

namespace Inputs.Touches
{
    internal sealed class TouchSystem : ITouchSystem
    {
        public ITapController TapController { get; }
        public ISwipeController SwipeController { get; }
        
        public TouchSystem()
        {
            EnhancedTouchSupport.Enable();
            
            TapController = new TapController();
            SwipeController = new SwipeController();
        }
    }
}