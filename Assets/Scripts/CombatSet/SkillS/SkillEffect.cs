using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.CombatSet.SkillS
{
    [Serializable]
    public class SkillEffect
    {
        public StatEnum UserEffectiveStat;
        public bool UseUserStat;
        public StatEnum EnemyAffectedStat;
        public Element element;
        public bool Percentage;
        public bool TargetSelf;
        public float EffectAmount;
        public int EffectTurnTime;
    }
}
