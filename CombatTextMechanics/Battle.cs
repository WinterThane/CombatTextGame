using CombatTextModels;

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

        public int PlayerDexterity()
        {
            return actor.Dexterity;
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
