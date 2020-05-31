using System;
using System.Collections.Generic;

namespace Gladiator.Gladiators
{
    public class GladiatorFactory
    {
        static Random random = new Random();

        public Gladiator GenerateRandomGladiator()
        {
            List<string> names = new List<string>{"imie1", "imie2", "imie3"};
            int randomClass = random.Next(1, 6);
            int randomLVL = random.Next(1, 6);
            int randomHP = random.Next(25, 101);
            int randomSP = random.Next(25, 101);
            int randomDEX = random.Next(25, 101);
            string randomName = names[random.Next(names.Count)];
            
            
            switch (randomClass)
            {
                case 1:
                    return new Archer(randomLVL, randomHP, randomSP, randomDEX, randomName);
                case 2: 
                    return new Assassin(randomLVL, randomHP, randomSP, randomDEX, randomName);
                case 3:
                    return new Brutal(randomLVL, randomHP, randomSP, randomDEX, randomName);
                case 4:
                    return new Swordsman(randomLVL, randomHP, randomSP, randomDEX, randomName);
                case 5:
                    return new Swordsman(randomLVL, randomHP, randomSP, randomDEX, randomName);
            }
        }
    }
}