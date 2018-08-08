using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace CombatTextModels
{
    public static class LoadJsonFunctions
    {
        public static List<Actor> GetAllClasses()
        {
            List<Actor> classes = new List<Actor>();
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\Classes\Classes.json");

            using (StreamReader reader = new StreamReader(path))
            {
                var json = reader.ReadToEnd();
                classes = JsonConvert.DeserializeObject<List<Actor>>(json);
            }

            return classes;
        }
    }
}
