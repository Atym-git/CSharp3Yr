using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatorCP
{
    internal abstract class AFabric
    {
        protected virtual Random Random { get; set; } = new Random();

        public abstract List<Monster> SpawnMonsters();
    }
}
