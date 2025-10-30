using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    internal class Enemy : ACreature
    {

        public Enemy(int health, int damage) : base(health, damage)
        {
        }

        public override void Die()
        {
            Console.WriteLine("Enemy has been defeated.");
        }
    }
}
