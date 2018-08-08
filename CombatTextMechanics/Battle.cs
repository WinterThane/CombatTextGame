using CombatTextModels;
using System.Collections.Generic;

namespace CombatTextMechanics
{
    public class Battle
    {
        public Player player = new Player("Winter", "Thief", 10, 10, 10, 10, 10);

        public List<string> GetClasses()
        {
            return player.GetClassNames();
        }

        public string PlayerName()
        {
            return player.Name;
        }

        public string PlayerClass()
        {
            return player.ClassName;
        }

        public int PlayerStrength()
        {
            return player.Strength;
        }

        public int PlayerIntelligence()
        {
            return player.Intelligence;
        }

        public int PlayerDexterity()
        {
            return player.Dexterity;
        }

        public int PlayerVitality()
        {
            return player.Vitality;
        }

        public int PlayerSpeed()
        {
            return player.Speed;
        }
    }
}
