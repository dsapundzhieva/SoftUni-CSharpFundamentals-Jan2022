using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._5_DragonArmy
{
    class Dragon
    {
        public Dragon(int demage, int health, int armor)
        {
            
            this.Damage = demage == null ? 45 : demage;
            this.Health = health == null ? 250 : health;
            this.Armor = armor == null ? 10 : armor;
        }
        public string Name { get; set; }

        public int Damage { get; set; }

        public int Health { get; set; }

        public int Armor { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dragon> stats = new Dictionary<string, Dragon>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                
                string type = command[0] + " " + command[1];
                
                int damage = int.Parse(command[2]);
                int health = int.Parse(command[3]);
                int armor = int.Parse(command[4]);

                Dragon dragon = new Dragon(damage, health, armor);

                if (!stats.ContainsKey(type))
                {
                    stats.Add(type, dragon);
                }
                else
                {
                    stats[type] = new Dragon(damage, health, armor);
                }

                var test = new Dictionary<string, string>();

                //test = stats.Select(x => x.Key.Split(" ", StringSplitOptions.RemoveEmptyEntries));
            }

        }
    }
}
