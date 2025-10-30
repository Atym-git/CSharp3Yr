using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeStrPat.SmartHomeFacade
{
    internal class Light
    {
        public float Brightness { get; private set; }
        public string Color { get; private set; }
        public bool IsTurnedOn { get; private set; }

        public void SwitchLight(bool isTurnedon)
        {
            IsTurnedOn = isTurnedon;
            if (IsTurnedOn)
            {
                Console.WriteLine($"Включили свет");
            }
            else Console.WriteLine($"Выключили свет");
        }

        public void ChangeBrightness(float brightness)
        {
            Brightness = brightness;
            Console.WriteLine($"Изменили яркость света на {Brightness} (из 100)");
        }
        public void ChangeColor(string color)
        {
            Color = color;
            Console.WriteLine($"Изменили цвет света на {Color}");
        }
        public override string ToString()
        {
            return $"IsTurnedOn = {IsTurnedOn}, Brightness = {Brightness}, Color = {Color}";
        }
    }
}
