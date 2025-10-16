using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviourPatterns
{
    internal class PersonalCar : IStrategy
    {
        public void TransferToAirport()
        {
            Console.WriteLine("Заправляем бензин, сразу выезжаем и прибываем в аэропорт за 4 часа");
        }
    }
}
