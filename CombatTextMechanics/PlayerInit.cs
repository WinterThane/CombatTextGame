namespace CombatTextMechanics
{
    public class PlayerInit : Actor
    {
        public string Name { get; set; }

        public PlayerInit(string name, string className, int strength, int intelligence, int dexterity, int vitality, int speed)
        {
            Name = name;
            ClassName = className;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Vitality = vitality;
            Speed = speed;
        } 
    }
}
