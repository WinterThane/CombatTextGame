namespace CombatTextModels
{
    public class Actor
    {
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int Vitality { get; set; }
        public int Speed { get; set; }

        public Actor()
        {
            Strength = 50;
            Intelligence = 40;
            Dexterity = 55;
            Vitality = 70;
            Speed = 50;
        }
    }
}
