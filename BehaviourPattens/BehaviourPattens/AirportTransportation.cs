using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BehaviourPatterns
{
    internal class AirportTransportation
    {
        public AirportTransportation(IStrategy IStrategy)
        {
            this.IStrategy = IStrategy;
        }

        public IStrategy IStrategy { get; set; }

        public void TransferToAirport()
        {
            IStrategy.TransferToAirport();
        }
    }
}
