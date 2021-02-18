using UnityEngine;
using UnityEngine.UI;

namespace Samples.UI
{
    public sealed class DialogView : MonoBehaviour, IDialogView
    {
        [SerializeField] private Selectable _selectableOnStart;
        
        public void Open()
        {
            gameObject.SetActive(true);
            _selectableOnStart.Select();
        }

        public void Close()
        {
            gameObject.SetActive(false);
        }
    }
}