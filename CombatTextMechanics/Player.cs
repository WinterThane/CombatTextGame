using System.Collections.Generic;

namespace CombatTextMechanics
{
    public static class Player
    {
        public static PlayerInit player = new PlayerInit("Winter", "Thief", 10, 10, 10, 10, 10);

        public static string PlayerName()
        {
            return player.Name;
        }

        public static string PlayerClass()
        {
            return player.ClassName;
        }

        public static int PlayerStrength()
        {
            return player.Strength;
        }

        public static int PlayerIntelligence()
        {
            return player.Intelligence;
        }

        public static int PlayerDexterity()
        {
            return player.Dexterity;
        }

        public static int PlayerVitality()
        {
            return player.Vitality;
        }

        public static int PlayerSpeed()
        {
            return player.Speed;
        }
    }
}
