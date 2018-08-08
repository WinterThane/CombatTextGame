using Newtonsoft.Json;
using System.Collections.Generic;

namespace CombatTextModels
{
    public class Player : Actor
    {
        public string Name { get; set; }

        [JsonConstructor]
        public Player(string name, string className, int strength, int intelligence, int dexterity, int vitality, int speed)
        {
            Name = name;
            ClassName = className;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Vitality = vitality;
            Speed = speed;
        }

        public List<string> GetClassNames()
        {
            var result = new List<string>();
            var classes = LoadJsonFunctions.GetAllClasses();

            foreach (var item in classes)
            {
                result.Add(item.ClassName);
            }

            return result;
        }
    }
}
