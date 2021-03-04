using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Samples.UI
{
    public sealed class SkillButtonView : MonoBehaviour, ISkillButtonView, IPointerDownHandler
    {
        public event Action Clicked;

        [SerializeField] private Text _nameSkillText;

        public void OnPointerDown(PointerEventData eventData)
        {
            CallClicked();
        }

        public void SetNameSkill(string nameSkill)
        {
            _nameSkillText.text = nameSkill;
        }

        private void CallClicked()
        {
            Clicked?.Invoke();
        }
    }
}