using UnityEngine;

namespace Inputs.Dpads
{
    public class Dpad : IDpad
    {
        private readonly InputControls.DpadActions _dpad;

        public IVector2 Position
        {
            get
            {
                var unityVector = _dpad.Move.ReadValue<Vector2>();
                return new CustomVector2(unityVector.x, unityVector.y);
            }
        }

        public Dpad(InputControls.DpadActions dpad)
        {
            _dpad = dpad;
            _dpad.Enable();
        }
    }
}