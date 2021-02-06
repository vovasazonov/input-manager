using Inputs.Dpads;
using Inputs.Touches;

namespace Inputs
{
    public interface IInputManager
    {
        IDpad Dpad { get; }
        ITouchSystem TouchSystem { get; }
    }
}