using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeStrPat.SmartHomeFacade
{
    internal class AirConditioner
    {
        public bool IsTurnedOn { get; private set; }
        public float Temperature { get; private set; }

        public void Switch(bool isTurnedon)
        {
            IsTurnedOn = isTurnedon;
            if (IsTurnedOn)
            {
                Console.WriteLine($"Включили кондиционер");
            }
            else Console.WriteLine($"Выключили кондиционер");
        }

        public void SetTemperature(float temperature)
        {
            Temperature = temperature;
            Console.WriteLine($"Изменили температуру кондиционера на {Temperature}");
        }
        public override string ToString()
        {
            return $"IsTurnedOn = {IsTurnedOn}, Temperature = {Temperature}";
        }
    }
}
