using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesCP
{
    internal class Warrior
    {
        private int health {  get; set; }
        private string name { get; set; }

        public Warrior(int health, string name)
        {
            this.health = health;
            this.name = name;
        }

        public void TakeDamage(int damage)
        {
            health -= damage;
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Remaining health = {health}");
        }
    }
}
