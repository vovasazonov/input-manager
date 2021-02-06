using System.Threading.Tasks;
using Inputs;
using Inputs.Touches;

namespace Scenes.Scripts.TouchSample
{
    public sealed class TapModel : ITapModel
    {
        private readonly ITouchSystem _touchSystem;
        public bool IsTap { get; private set; }
        public int AmountTap { get; private set; }
        
        public TapModel(ITouchSystem touchSystem)
        {
            _touchSystem = touchSystem;
            AddTapListener();
        }

        private void AddTapListener()
        {
            _touchSystem.TapController.Tapped += OnTapped;
        }

        private void RemoveTapListener()
        {
            _touchSystem.TapController.Tapped -= OnTapped;
        }
        
        private void OnTapped(IVector2 screenPosition, int amountTap)
        {
            IsTap = true;
            AmountTap = amountTap;
        }
    }
}