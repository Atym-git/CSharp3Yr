namespace ConsoleRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {      

            Enemy enemy = new Enemy(5, 2);
            enemy.TakeDamage(3);
            enemy.TakeDamage(3);
        }
    }
}
