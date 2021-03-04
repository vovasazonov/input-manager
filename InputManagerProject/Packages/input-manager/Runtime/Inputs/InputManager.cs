namespace Inputs
{
    public sealed class InputManager : IInputManager
    {
        public IPlayerControl PlayerControl { get; }

        public InputManager()
        {
            var playerActions = new PlayerActions();

            PlayerControl = new PlayerControl(playerActions);
        }
    }
}