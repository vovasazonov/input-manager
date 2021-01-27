using UnityEngine;

namespace Inputs
{
    public class Dpad : IDpad
    {
        private readonly InputControls.DpadActions _dpad;

        public IVector2 CurrentPosition => new CustomVector2(_dpad.Move.ReadValue<Vector2>());

        public Dpad()
        {
            _dpad = new InputControls().Dpad;
            _dpad.Enable();
        }
    }
}