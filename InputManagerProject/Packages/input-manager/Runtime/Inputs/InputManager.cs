namespace Inputs
{
    public sealed class InputManager : IInputManager
    {
        private readonly InputControls _inputControls;
        public IDpad Dpad { get; }

        public InputManager()
        {
            _inputControls = new InputControls();
            Dpad = new Dpad(_inputControls.Dpad);
        }
    }
}