using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace CombatTextMechanics.Functions
{
    public static class SaveLoadJson
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

        public static void SaveNewHero(Player player)
        {
            if (!Directory.Exists(@"Data\Player\"))
            {
                Directory.CreateDirectory(@"Data\Player\");
            }

            using (StreamWriter file = File.CreateText(@"Data\Player\" + player.Name + ".json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, player);
            }
        }

        public static Player LoadHero(string name)
        {
            var player = new Player();

            using (StreamReader file = File.OpenText(@"Data\Player\" + name + ".json"))
            {
                JsonSerializer serialiezr = new JsonSerializer();
                player = (Player)serialiezr.Deserialize(file, typeof(Player));
            }

            return player;
        }
    }
}
