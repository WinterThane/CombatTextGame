﻿using System.Collections.Generic;

namespace CombatTextMechanics
{
    public class ClassesInit
    {
        public List<Actor> GetClasses()
        {
            var result = new List<Actor>();
            var classes = LoadJsonFunctions.GetAllClasses();

            foreach (var item in classes)
            {
                result.Add(item);
            }

            return result;
        }

        public List<string> GetClassNames()
        {
            var result = new List<string>();
            var classes = GetClasses();

            foreach (var item in classes)
            {
                result.Add(item.ClassName);
            }

            return result;
        }

        public Dictionary<string, string> GetClassStats(string input)
        {
            var classes = GetClasses();
            var result = new Dictionary<string, string>();

            foreach (var item in classes)
            {
                if(item.ClassName == input)
                {
                    result.Add("Strength", item.Strength.ToString());
                    result.Add("Intelligence", item.Intelligence.ToString());
                    result.Add("Dexterity", item.Dexterity.ToString());
                    result.Add("Vitality", item.Vitality.ToString());
                    result.Add("Speed", item.Speed.ToString());
                }
            }

            return result;
        }
    }
}
