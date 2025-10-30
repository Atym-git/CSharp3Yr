using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeStrPat.SmartHomeFacade
{
    internal class MusicStation
    {
        public bool IsTurnedOn { get; private set; }
        public string Music { get; private set; }

        public void Switch(bool isTurnedon)
        {
            IsTurnedOn = isTurnedon;
            if (IsTurnedOn)
            {
                Console.WriteLine($"Включили музыку");
            }
            else Console.WriteLine($"Выключили музыку");
        }

        public void SetMusic(string music)
        {
            Music = music;
            Console.WriteLine($"Поменяли музыку на: {Music}");
        }
        public override string ToString()
        {
            return $"IsTurnedOn = {IsTurnedOn}, Music = {Music}";
        }
    }
}
