using SmartHomeStrPat.SmartHomeFacade;

namespace SmartHomeStrPat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            AirConditioner airConditioner = new AirConditioner();
            MusicStation musicStation = new MusicStation();
            TV tv = new TV();

            SmartHome smartHome = new SmartHome(light, musicStation, airConditioner, tv);

            smartHome.SetupHome(HomeState.GoingOut);
        }
    }
}
