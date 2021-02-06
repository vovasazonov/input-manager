using Inputs;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Scripts.TouchSample
{
    public sealed class TapView : MonoBehaviour, ITapView
    {
        [SerializeField] private Text _positionText;
        [SerializeField] private Text _amountTapText;

        public IVector2 Position
        {
            set
            {
                var position = value;
                _positionText.text = $"Position tap. X: {position.X} Y: {position.Y}";
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