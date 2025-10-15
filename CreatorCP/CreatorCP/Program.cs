using System.Diagnostics;

namespace CreatorCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EasyLevelFabric easyFabric = new EasyLevelFabric();
            MediumLevelFabric mediumFabric = new MediumLevelFabric();
            HighLevelFabric highFabric = new HighLevelFabric();

            List<Monster> monsters = new List<Monster>();

            Console.WriteLine("Введите цифру от 1 до 3");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1: monsters = easyFabric.SpawnMonsters();
                    break;
                
                case 2: monsters = mediumFabric.SpawnMonsters();
                    break;
                
                case 3: monsters = highFabric.SpawnMonsters();
                    break;
            }

            Console.WriteLine($"Монстров заспавнило: {monsters.Count}");
            foreach (Monster monster in monsters)
            {
                monster.DisplayInfo();
            }
        }
    }

    enum Level
    {
        Small = 1,
        Medium = 2,
        High = 3
    };

}
