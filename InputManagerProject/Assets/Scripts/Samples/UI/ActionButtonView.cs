using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Samples.UI
{
    public sealed class ActionButtonView: MonoBehaviour, IActionButtonView, IPointerDownHandler
    {
        public event Action Clicked;

        [SerializeField] private Text _nameKeyText;
        
        public void SetNameKey(string nameKey)
        {
            _nameKeyText.text = nameKey;
        }

        private void CallClicked()
        {
            Clicked?.Invoke();
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            CallClicked();
        }
    }
}