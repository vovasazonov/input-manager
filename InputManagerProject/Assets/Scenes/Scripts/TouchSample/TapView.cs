using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Scripts.TouchSample
{
    public sealed class TapView : MonoBehaviour, ITapView
    {
        [SerializeField] private Text _isTapText;
        [SerializeField] private Text _amountTapText;

        public bool IsTap
        {
            set
            {
                var isTap = value;
                _isTapText.text = $"Is tap: {isTap}";
            }
        }

        public int AmountTap
        {
            set
            {
                var amountTap = value;
                _amountTapText.text = $"Amount tap: {amountTap}";
            }
        }
    }
}