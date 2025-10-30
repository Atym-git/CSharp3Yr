using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    internal class Player : ACreature
    {
        Random rnd = new Random();

        private string _name;

        protected float critChance;

        public Player(string name)
        {
            _name = name;
        }

        //public Player(int health, int damage, float critChance, string name) : base(health, damage)
        //{
        //    _name = name;
        //    _critChance = critChance;
        //}

        public virtual void Attack(Enemy enemy)
        {
            int rndNum = rnd.Next(0, 10);

            int playerDamage = Damage;

            if (rndNum < (critChance * 10))
            {
                Console.WriteLine("Crit! You did twice as much dmg to your enemy");
                playerDamage *= 2;
            }
            enemy.TakeDamage(playerDamage);
        }

        public override void Die()
        {
            Console.WriteLine("Game over. You died(");
        }
    }
}
