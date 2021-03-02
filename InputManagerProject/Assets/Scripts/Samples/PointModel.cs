using Inputs;
using Inputs.Actions;

namespace Samples
{
    public sealed class PointModel : IPointModel
    {
        public event ColorChangedHandler ColorChanged;
        public event PositionChangedHandler PositionChanged;
        public event NumberChangedHandler NumberChanged;
        public event ScaledHandler Scaled;

        private readonly IPlayerControl _playerControl;

        public PointModel(IPlayerControl playerControl)
        {
            _playerControl = playerControl;
            
            AddPlayerControlListener();
        }
        
        private void AddPlayerControlListener()
        {
            _playerControl.TapAction.Tapped += OnTapped;
            _playerControl.SwipeAction.Started += OnSwipeStarted;
            _playerControl.SwipeAction.Proceed += OnSwipeProceed;
            _playerControl.SwipeAction.Stopped += OnSwipeStopped;
            _playerControl.ScaleAction.Scaled += OnScaled;
        }

        private void RemovePlayerControlListener()
        {
            _playerControl.TapAction.Tapped -= OnTapped;
            _playerControl.SwipeAction.Started -= OnSwipeStarted;
            _playerControl.SwipeAction.Proceed -= OnSwipeProceed;
            _playerControl.SwipeAction.Stopped -= OnSwipeStopped;
            _playerControl.ScaleAction.Scaled -= OnScaled;
        }

        private void OnScaled()
        {
            var scale = _playerControl.ScaleAction.TotalMagnitude;
            CallScaled(scale);
        }

        private void OnSwipeStopped(ISwipeInfo swipeInfo)
        {
            CallPositionChanged(swipeInfo.StartPosition);
        }

        private void OnSwipeProceed(ISwipeInfo swipeInfo)
        {
            CallPositionChanged(swipeInfo.CurrentPosition);
        }

        private void OnSwipeStarted(ISwipeInfo swipeInfo)
        {
            CallColorChanged(PointColor.Blue);
        }

        private void OnTapped(IVector2 screenPosition, int amount)
        {
            CallNumberChanged(amount);
            CallPositionChanged(screenPosition);
            CallColorChanged(PointColor.Red);
        }

        private void CallColorChanged(PointColor pointerColor)
        {
            ColorChanged?.Invoke(pointerColor);
        }

        private void CallPositionChanged(IVector2 position)
        {
            PositionChanged?.Invoke(position);
        }

        private void CallNumberChanged(int number)
        {
            NumberChanged?.Invoke(number);
        }

        private void CallScaled(float scale)
        {
            Scaled?.Invoke(scale);
        }
    }
}