using UnityEngine;
using UnityEngine.UI;

namespace DpadSample
{
    public sealed class StickCoordinatesView : MonoBehaviour, IStickCoordinatesView
    {
        [SerializeField] private Text _coordinateText;

        private string _x;
        private string _y;
        
        public string X
        {
            set
            {
                _x = value;
                UpdateView();
            }
        }

        public string Y
        {
            set
            {
                _y = value;
                UpdateView();
            }
        }

        private void UpdateView()
        {
            _coordinateText.text = $"Stick coordinates: x:{_x}  y:{_y}";
        }
    }
}