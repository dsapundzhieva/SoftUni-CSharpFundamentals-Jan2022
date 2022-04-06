using System;
using System.Collections.Generic;

namespace _4._3_HeroesOfCodeandLogicVII
{
    class Hero
    {
        public Hero(int hitPoints, int manaPoints)
        {
            this.HitPoint = hitPoints;
            this.ManaPoints = manaPoints;
        }
        public int HitPoint { get; set; }
        public int ManaPoints { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();



            for (int i = 0; i < n; i++)
            {
                var heroArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string heroName = heroArgs[0];
                int hitPoints = int.Parse(heroArgs[1]);
                int manaPoints = int.Parse(heroArgs[2]);

                hitPoints = hitPoints > 100 ? 100 : hitPoints;
                manaPoints = manaPoints > 200 ? 200 : manaPoints;

                Hero hero = new Hero(hitPoints, manaPoints);
                heroes.Add(heroName, hero);
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
                    if (heroes.ContainsKey(heroName))
                    {
                        if (heroes[heroName].ManaPoints >= manaPoints)
                        {
                            heroes[heroName].ManaPoints -= manaPoints;
                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName].ManaPoints} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                        }
                    }

                }
                else if (cmdType == "TakeDamage")
                {
                    string heroName = cmdArgs[1];
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];

                    if (heroes.ContainsKey(heroName))
                    {
                        heroes[heroName].HitPoint -= damage;
                        if (heroes[heroName].HitPoint <= 0)
                        {
                            heroes.Remove(heroName);
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName].HitPoint} HP left!");
                        }
                    }
                }
                else if (cmdType == "Recharge")
                {
                    string heroName = cmdArgs[1];
                    int amount = int.Parse(cmdArgs[2]);

                    if (heroes.ContainsKey(heroName))
                    {
                        int currMP = 0;
                        if (heroes[heroName].ManaPoints + amount > 200)
                        {
                            currMP = 200 - heroes[heroName].ManaPoints;
                            heroes[heroName].ManaPoints = 200;
                        }
                        else
                        {
                            currMP = amount;
                            heroes[heroName].ManaPoints += currMP;
                        }
                        Console.WriteLine($"{heroName} recharged for {currMP} MP!");
                    }
                }
                else if (cmdType == "Heal")
                {
                    string heroName = cmdArgs[1];
                    int amount = int.Parse(cmdArgs[2]);

                    if (heroes.ContainsKey(heroName))
                    {
                        int currHP = 0;
                        if (heroes[heroName].HitPoint + amount > 100)
                        {
                            currHP = 100 - heroes[heroName].HitPoint;
                            heroes[heroName].HitPoint = 100;
                        }
                        else
                        {
                            currHP = amount;
                            heroes[heroName].HitPoint += currHP;
                        }
                        Console.WriteLine($"{heroName} healed for {currHP} HP!");
                    }
                }
            }

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value.HitPoint}");
                Console.WriteLine($"  MP: {hero.Value.ManaPoints}");
            }
        }
    }
}
