using UnityEngine;

namespace Inputs.Actions.Pinch
{
    public readonly struct PinchInfo : IPinchInfo
    {
        private readonly float _startMagnitude;
        private readonly IVector2[] _currentPositions;

        public float PinchValue => CurrentMagnitude / _startMagnitude;
        public float CurrentMagnitude => _currentPositions[0].Distance(_currentPositions[1]);
        public float TotalMagnitude => Mathf.Abs(CurrentMagnitude - _startMagnitude);
        public float Sign => Mathf.Sign(CurrentMagnitude - _startMagnitude);

        public PinchInfo(float startMagnitude, IVector2 firstFingerCurrentPosition, IVector2 secondFingerCurrentPosition)
        {
            _startMagnitude = startMagnitude;
            _currentPositions = new[] {firstFingerCurrentPosition, secondFingerCurrentPosition};
        }
    }
}