using Inputs;

namespace Scenes.Scripts.DpadSample
{
    public class DpadModel : IDpadModel
    {
        private readonly IDpad _dpad;
        public IVector2 Position => _dpad.Position;

        public DpadModel(IDpad dpad)
        {
            _dpad = dpad;
        }
    }
}