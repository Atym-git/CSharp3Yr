namespace ATMThreadingCP
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();

            int threadsAmount = rnd.Next(4, 7);
            Thread[] threads = new Thread[threadsAmount];

            for (int i = 0; i < threadsAmount; i++)
            {
                ATM atm = new ATM(25, 60);

                threads[i] = new Thread(atm.Withdraw);
                threads[i].Name = $"Thread {i}";

                int withdrawsAmount = rnd.Next(8, 13);
                threads[i].Start(withdrawsAmount);
                
            }

            while (threads[threads.Length - 1].IsAlive)
            {
                Thread.Sleep(200);
            }
            Console.WriteLine($"У вас на счету осталось: {ATM.CurrBalance} рублей");
        }
    }
}
