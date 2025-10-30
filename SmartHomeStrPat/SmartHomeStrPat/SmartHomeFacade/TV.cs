using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeStrPat.SmartHomeFacade
{
    internal class TV
    {
        public bool IsTurnedOn { get; private set; }

        public string Program {  get; private set; }

        public void SwitchTV(bool isTurnedon)
        {
            IsTurnedOn = isTurnedon;
            if (IsTurnedOn)
            {
                Console.WriteLine($"Включили телевизор");
            }
            else Console.WriteLine($"Выключили телевизор");
        }

        public void SwitchProgram(string program)
        {
            Program = program;
            Console.WriteLine($"Включили {program} на телевизоре");
        }

        public override string ToString()
        {
            return $"IsTurnedOn = {IsTurnedOn}, Program = {Program}";
        }
    }
}
