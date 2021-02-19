using UnityEngine;
using UnityEngine.UI;

namespace Samples.UI
{
    public sealed class SkillPerformView : MonoBehaviour, ISkillPerformView
    {
        [SerializeField] private Text _nameSkillText;
        
        public void SetNamePerformedSkill(string name)
        {
            _nameSkillText.text = name;
        }
    }
}