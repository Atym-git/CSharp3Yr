using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviourPatterns
{
    internal class Taxi : IStrategy
    {
        public void TransferToAirport()
        {
            Random random = new Random();
            int minutesTillTaxi = random.Next(15, 50);
            Console.WriteLine($"Заказываем такси, которое прибывает через {minutesTillTaxi} минут");

            Console.WriteLine($"После {minutesTillTaxi} минут садимся в такси и прибываем в аэропорт за 3 часа");
        }
    }
}
