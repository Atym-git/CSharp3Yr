using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    internal class EnemyFabric
    {
        private static readonly int ENM_MAX_HEALTH = 25;
        private static readonly int ENM_MIN_HEALTH = 10;
        private static readonly int ENM_MAX_DMG = 7;
        private static readonly int ENM_MIN_DMG = 3;

        Random rnd = new Random();
        public Enemy CreateEnemy()
        {
            int enemyRndHealth = rnd.Next(ENM_MIN_HEALTH, ENM_MAX_HEALTH);
            int enemyRndDmg = rnd.Next(ENM_MIN_DMG, ENM_MAX_DMG);

            Enemy enemy = new Enemy(enemyRndHealth, enemyRndDmg);
            return enemy;
        }
    }
}
