using System;
using Inputs.Touches;

namespace TouchSample.Swipe
{
    public sealed class CameraSwipeModel : ICameraSwipeModel
    {
        public event DisplaceHandler Displaced;

        private readonly ITouchSystem _touchSystem;
        private readonly float _displaceSpeed = 0.01f;

        public CameraSwipeModel(ITouchSystem touchSystem)
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
            _touchSystem.SwipeGesture.Proceed -= OnSwipeProceed;
        }

        private void OnSwipeProceed(ISwipeInfo swipeInfo)
        {
            DetectMagnitudeSwipe(swipeInfo);
        }

        private void DetectMagnitudeSwipe(ISwipeInfo swipeInfo)
        {
            if (swipeInfo.FingerId == 0)
            {
                var vectorSwipe = (swipeInfo.CurrentPosition.X - swipeInfo.StartPosition.X, swipeInfo.CurrentPosition.Y - swipeInfo.StartPosition.Y);
                var normalizeVectorSwipe = GetNormalizeVector(vectorSwipe.Item1, vectorSwipe.Item2);

                CallDisplaced(normalizeVectorSwipe.Item1 * _displaceSpeed, normalizeVectorSwipe.Item2 * _displaceSpeed);
            }
        }

        private (float, float) GetNormalizeVector(float x, float y)
        {
            float distance = (float) Math.Sqrt(x * x + y * y);
            return (x / distance, y / distance);
        }

        private void CallDisplaced(float displaceX, float displaceY)
        {
            Displaced?.Invoke(displaceX, displaceY);
        }
    }
}