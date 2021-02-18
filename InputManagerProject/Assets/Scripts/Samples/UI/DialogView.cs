using UnityEngine;

namespace Samples.UI
{
    public sealed class DialogView : MonoBehaviour, IDialogView
    {
        public void Open()
        {
            gameObject.SetActive(true);
        }

        public void Close()
        {
            gameObject.SetActive(false);
        }
    }
}