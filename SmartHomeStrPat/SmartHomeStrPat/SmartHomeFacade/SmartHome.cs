using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeStrPat.SmartHomeFacade
{
    internal class SmartHome
    {
        private Light light;
        private MusicStation musicStation;
        private AirConditioner airConditioner;
        private TV tv;

        public SmartHome(Light light, MusicStation musicStation, AirConditioner airConditioner, TV tv)
        {
            this.light = light;
            this.musicStation = musicStation;
            this.airConditioner = airConditioner;
            this.tv = tv;
        }

        public void SetupHome(HomeState homeState)
        {
            switch (homeState)
            {
                case HomeState.Party:
                    light.SwitchLight(true);
                    light.ChangeBrightness(15);
                    light.ChangeColor("red");

                    musicStation.Switch(true);
                    musicStation.SetMusic("Eminem - Ream Slim Shady");

                    airConditioner.Switch(true);
                    airConditioner.SetTemperature(18);

                    tv.SwitchTV(true);
                    tv.SwitchProgram("Truth or Dare");
                        break;

                case HomeState.Morning:
                    light.SwitchLight(true);
                    light.ChangeBrightness(60);
                    light.ChangeColor("white");

                    musicStation.Switch(true);
                    musicStation.SetMusic("Morning Refreshing song");

                    airConditioner.Switch(true);
                    airConditioner.SetTemperature(24);

                    tv.SwitchTV(true);
                    tv.SwitchProgram("Fresh News");
                        break;

                case HomeState.GettingReady:
                    light.SwitchLight(true);
                    light.ChangeBrightness(60);
                    light.ChangeColor("white");

                    musicStation.Switch(true);
                    musicStation.SetMusic("Motivating song");

                    airConditioner.Switch(false);

                    tv.SwitchTV(false);

                        break;

                case HomeState.GoingOut:

                    light.SwitchLight(false);

                    musicStation.Switch(false);

                    airConditioner.Switch(false);

                    tv.SwitchTV(false);

                        break;

                case HomeState.AloneAtHome:

                    light.SwitchLight(true);
                    light.ChangeBrightness(50);
                    light.ChangeColor("white");

                    musicStation.Switch(false);

                    airConditioner.Switch(true);
                    airConditioner.SetTemperature(24);

                    tv.SwitchTV(true);
                    tv.SwitchProgram("Кинопоиск");

                        break;
            }

            Console.WriteLine();

            ToString();
        }

        private void ToString()
        {
            Console.WriteLine("Свойства света: " + light.ToString());
            Console.WriteLine("Свойства музыки: " + musicStation.ToString());
            Console.WriteLine("Свойства кондиционера: " + airConditioner.ToString());
            Console.WriteLine("Свойства телевизора: " + tv.ToString());
        }

    }

    enum HomeState
    {
        Party = 0,
        Morning = 1,
        GettingReady = 2,
        GoingOut = 3,
        AloneAtHome = 4
    }
}
