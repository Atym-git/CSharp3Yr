using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatorCP
{
    internal class EasyLevelFabric : AFabric
    {
        public override List<Monster> SpawnMonsters()
        {
            List<Monster> monsters = new List<Monster>();

            int monstersLevel = 10;

            int monstersAmount = Random.Next(1, 6);

            for (int i = 0; i < monstersAmount; i++)
            {
                int monsterStrength = Random.Next(1, 50);

                Monster monster = new Monster(monstersLevel, monsterStrength, 0);

                monsters.Add(monster);
            }

            return monsters;
        }
    }
}
