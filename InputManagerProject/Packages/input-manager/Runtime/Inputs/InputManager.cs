namespace Inputs
{
    public sealed class InputManager : IInputManager
    {
        public IPlayerControls PlayerControls { get; }

        public InputManager()
        {
            var playerActions = new PlayerActions();
            
            PlayerControls = new PlayerControls(playerActions);
        }
    }
}