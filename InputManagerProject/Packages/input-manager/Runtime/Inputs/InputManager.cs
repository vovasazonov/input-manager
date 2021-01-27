namespace Inputs
{
    public class InputManager : IInputManager
    {
        public IDpad Dpad { get; }

        public InputManager(IDpad dpad)
        {
            Dpad = dpad;
        }
    }
}