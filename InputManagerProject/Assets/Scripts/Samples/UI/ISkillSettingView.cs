using System;

namespace Samples.UI
{
    public interface ISkillSettingView
    {
        event Action Clicked;

        void SetNameBindPath(string nameKey);
        void SetNameSkill(string nameSkill);
    }
}