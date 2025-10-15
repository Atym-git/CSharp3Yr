using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatorCP
{
    internal class MediumLevelFabric : AFabric
    {
        public override List<Monster> SpawnMonsters()
        {
            List<Monster> monsters = new List<Monster>();

            int monstersLevel = 25;

            int monstersAmount = Random.Next(1, 6);

            for (int i = 0; i < monstersAmount; i++)
            {
                int monsterStrength = Random.Next(50, 100);

                Monster monster = new Monster(monstersLevel, monsterStrength, 0);

                monsters.Add(monster);
            }

            return monsters;
        }
    }
}
