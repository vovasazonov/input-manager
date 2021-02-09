using Inputs.Dpads;

namespace Inputs
{
    public interface IInputManager
    {
        IDpad Dpad { get; }
    }
}