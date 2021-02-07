using Inputs.Touches;

namespace Scenes.Scripts.TouchSample.Swipe
{
    public sealed class CameraModel : ICameraModel
    {
        public event MovedHandler Moved;
        
        private readonly ITouchSystem _touchSystem;

        public CameraModel(ITouchSystem touchSystem)
        {
            _touchSystem = touchSystem;
                
            AddTouchSystemListener();
        }

        private void AddTouchSystemListener()
        {
            _touchSystem.SwipeGesture.Proceed += OnSwipeProceed;
        }

        private void RemoveTouchSystemListener()
        {
            _touchSystem.SwipeGesture.Proceed += OnSwipeProceed;
        }

        private void OnSwipeProceed(ISwipeInfo swipeInfo)
        {
            var deltaX = swipeInfo.CurrentPosition.X - swipeInfo.StartPosition.X;
            var deltaY = swipeInfo.CurrentPosition.Y - swipeInfo.StartPosition.Y;
            
            CallMoved(deltaX, deltaY);
        }

        private void CallMoved(float deltaX, float deltaY)
        {
            Moved?.Invoke(deltaX, deltaY);
        }
    }
}