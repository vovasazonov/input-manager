namespace Inputs
{
    public sealed class InputManager : IInputManager
    {
        public IDpad Dpad { get; }

        public InputManager()
        {
            Dpad = new Dpad();
        }
    }
}