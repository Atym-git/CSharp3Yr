using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviourPatterns
{
    internal class ExpressTrain : IStrategy
    {
        public void TransferToAirport()
        {
            Random random = new Random();
            int hoursTillTrain = random.Next(1, 10);
            Console.WriteLine($"Покупаем билеты на поезд через {hoursTillTrain} час (-а, -ов)");

            Console.WriteLine($"После {hoursTillTrain} часов садимся на поезд и прибываем в аэропорт за 2 часа");
        }
    }
}
