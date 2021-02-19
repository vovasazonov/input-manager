using System;
using UnityEngine;
using UnityEngine.UI;

namespace Samples.UI
{
    public sealed class SkillSettingView : MonoBehaviour, ISkillSettingView
    {
        public event Action Clicked;

        [SerializeField] private Text _nameSkillText;
        [SerializeField] private Text _nameBindPathText;
        [SerializeField] private Button _changeBindPathButton;

        private void Awake()
        {
            AddButtonListener();
        }

        private void AddButtonListener()
        {
            _changeBindPathButton.onClick.AddListener(OnClick);
        }

        private void RemoveButtonListener()
        {
            _changeBindPathButton.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            _nameBindPathText.text = "listen...";
            CallClicked();
        }

        public void SetNameBindPath(string nameKey)
        {
            _nameBindPathText.text = nameKey;
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