using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatorCP
{
    public class Monster
    {
        private int level;
        private int strength;
        private static Dictionary<int, string> ClassDictionary = new Dictionary<int, string>()
        {
            {1, "Bee" },
            {2, "Wolf" },
            {3, "Bear" }
        };

        private int monsterClassIndex;

        public Monster(int level, int strength, int classIndex)
        {
            this.level = level;
            this.strength = strength;
            monsterClassIndex = classIndex;
            if (classIndex == 0)
            {
                Random rand = new Random();
                monsterClassIndex = rand.Next(1, ClassDictionary.Count + 1);
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Уровень Монстра: {level} Класс Монстра: {ClassDictionary[monsterClassIndex]}, Сила: {strength}");
        }

    }

}
