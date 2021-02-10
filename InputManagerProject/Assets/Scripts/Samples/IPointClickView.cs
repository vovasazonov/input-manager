using Inputs;

namespace Samples
{
    public interface IPointClickView
    {
        void SetPosition(IVector2 position);
        void SetAmountTap(int amount);
    }
}