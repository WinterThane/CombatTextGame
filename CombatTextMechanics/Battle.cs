using CombatTextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatTextMechanics
{
    public class Battle
    {
        public Actor actor = new Actor();

        public int PlayerStrength()
        {
            return actor.Strength;
        }

        public int PlayerIntelligence()
        {
            return actor.Intelligence;
        }

        public int PlayerVitality()
        {
            return actor.Vitality;
        }

        public int PlayerSpeed()
        {
            return actor.Speed;
        }
    }
}
