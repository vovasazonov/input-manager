using UnityEngine;
using UnityEngine.UI;

namespace Samples
{
    public sealed class CoordinatesView : MonoBehaviour, ICoordinatesView
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
            _coordinateText.text = $"Coordinates: x:{_x}  y:{_y}";
        }
    }
}