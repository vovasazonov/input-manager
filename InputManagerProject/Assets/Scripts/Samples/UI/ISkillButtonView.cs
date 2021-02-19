using System;

namespace Samples.UI
{
    public interface ISkillButtonView
    {
        event Action Clicked;

        void SetNameSkill(string nameSkill);
    }
}