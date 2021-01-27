using UnityEngine;

namespace Inputs
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

        public Dpad()
        {
            _dpad = new InputControls().Dpad;
            _dpad.Enable();
        }
    }
}