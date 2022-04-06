using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._3_Heroes_of_Code_and_Logic_VII
{
    class Hero
    {
        public Hero(string name, int hitPoints, int manaPoints)
        {
            this.HeroName = name;
            this.HitPoints = hitPoints;
            this.ManaPoints = manaPoints;
        }
        public string HeroName { get; set; }

        public int HitPoints { get; set; }

        public int ManaPoints { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Hero> heroList = new List<Hero>();

            for (int i = 0; i < n; i++)
            {
                var cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string heroName = cmdArgs[0];
                int hitPoints = int.Parse(cmdArgs[1]);
                int manaPoints = int.Parse(cmdArgs[2]);

                hitPoints = hitPoints > 100 ? 100 : hitPoints;
                manaPoints = manaPoints > 200 ? 200 : manaPoints;

                Hero hero = new Hero(heroName, hitPoints, manaPoints);
                heroList.Add(hero);
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var cmdArgs = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];
                if (cmdType == "CastSpell")
                {
                    string heroName = cmdArgs[1];
                    int manaPoints = int.Parse(cmdArgs[2]);
                    string spellName = cmdArgs[3];

                    CastTheSpell(heroList, heroName, manaPoints, spellName);
                }
                else if (cmdType == "TakeDamage")
                {
                    string heroName = cmdArgs[1];
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];

                    TakeDemage(heroList, heroName, damage, attacker);
                }
                else if (cmdType == "Recharge")
                {
                    string heroName = cmdArgs[1];
                    int amount = int.Parse(cmdArgs[2]);

                    RechargeManaPoints(heroList, heroName, amount);
                }
                else if (cmdType == "Heal")
                {
                    string heroName = cmdArgs[1];
                    int amount = int.Parse(cmdArgs[2]);

                    IncreaseHitPoints(heroList, heroName, amount);
                }
            }
            PrinOut(heroList);
        }

        static void PrinOut(List<Hero> heroList)
        {
            foreach (var hero in heroList)
            {
                Console.WriteLine(hero.HeroName);
                Console.WriteLine($"  HP: {hero.HitPoints}");
                Console.WriteLine($"  MP: {hero.ManaPoints}");
            }
        }

        static void IncreaseHitPoints(List<Hero> heroList, string heroName, int amount)
        {
            Hero hero = heroList.FirstOrDefault(x => x.HeroName == heroName);
            int recharged = hero.HitPoints + amount >= 100 ? 100 - hero.HitPoints : amount;

            Console.WriteLine($"{hero.HeroName} healed for {recharged} HP!");

            hero.HitPoints += recharged;

        }
        static void RechargeManaPoints(List<Hero> heroList, string heroName, int amount)
        {
            Hero hero = heroList.FirstOrDefault(x => x.HeroName == heroName);
            int recharged = hero.ManaPoints + amount >= 200 ? 200 - hero.ManaPoints : amount;
            Console.WriteLine($"{hero.HeroName} recharged for {recharged} MP!");

            hero.ManaPoints += recharged;
        }

        static void TakeDemage(List<Hero> heroList, string heroName, int damage, string attacker)
        {
            Hero defender = heroList.FirstOrDefault(x => x.HeroName == heroName);
            defender.HitPoints -= damage;
            if (defender.HitPoints > 0)
            {
                Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {defender.HitPoints} HP left!");
            }
            else
            {
                heroList.Remove(defender);
                Console.WriteLine($"{heroName} has been killed by {attacker}!");
            }

        }

        static void CastTheSpell(List<Hero> heroList, string heroName, int manaPoints, string spellName)
        {
            Hero hero = heroList.FirstOrDefault(x => x.HeroName == heroName);

            if (hero.ManaPoints >= manaPoints)
            {
                hero.ManaPoints -= manaPoints;
                Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {hero.ManaPoints} MP!");
            }
            else
            {
                Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
            }
        }
    }
}
