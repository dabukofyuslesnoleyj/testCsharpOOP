using System;
using System.Collections.Generic;

namespace testCsharpOOP
{

    abstract class SkillUser
    {
        protected Dictionary<string, ISkill> skills;

        protected void addSkill (string skillName, ISkill skill)
        {
            if (skills != null)
            {
                skills.Add(skillName, skill);
            }
        }

        public void useSkill (string skillName, Unit targetUnit)
        {
            if (skills != null)
            {
                skills[skillName].use(targetUnit);
            }
        }
    }

}