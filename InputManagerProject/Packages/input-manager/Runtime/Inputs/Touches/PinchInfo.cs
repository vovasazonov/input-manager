using UnityEngine;

namespace Inputs.Touches
{
    public readonly struct PinchInfo
    {
        private readonly float _startMagnitude;
        private readonly Vector2[] _currentPositions;

        public float PinchValue => Vector2.Distance(_currentPositions[0], _currentPositions[1]) / _startMagnitude;

        public float CurrentMagnitude => Vector2.Distance(_currentPositions[0], _currentPositions[1]);

        public float TotalMagnitude => CurrentMagnitude - _startMagnitude;

        public PinchInfo(float startMagnitude, Vector2 firstFingerCurrentPosition, Vector2 secondFingerCurrentPosition)
        {
            _startMagnitude = startMagnitude;
            _currentPositions = new Vector2[] { firstFingerCurrentPosition, secondFingerCurrentPosition };
        }
    }
}