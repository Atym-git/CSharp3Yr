using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    abstract public class ACreature
    {
        protected int Health;
        protected int Damage;

        public ACreature() { }
        public ACreature(int health, int damage)
        {
            Health = health;
            Damage = damage;
        }

        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                Die();
            }
        }
        public abstract void Die();
    }
}
