using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Scripts.DpadSample
{
    public sealed class DpadCoordinatesView : MonoBehaviour, IDpadCoordinatesView
    {
        [SerializeField] private Text _text;

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
            _text.text = $"Dpad coordinates: x:{_x}  y:{_y}";
        }
    }
}