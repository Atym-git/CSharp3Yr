using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ATMThreadingCP
{
    internal class ATM
    {
        public static object locker = new object();

        Random rnd = new Random();

        public static int CurrBalance { get; private set; } = 1000;

        private int _minWithdrawAmount = 5;
        private int _maxWithdrawAmount = 20;

        public ATM()
        {
        }
        
        public ATM(int minWithdrawAmount, int maxWithdrawAmount)
        {
            _minWithdrawAmount = minWithdrawAmount;
            _maxWithdrawAmount = maxWithdrawAmount;
        }

        public void Withdraw(object? amountOfWithdrawTries)
        {
            lock (locker)
            {
                if (amountOfWithdrawTries is int result)
                {
                    for (int i = 0; i < result; i++)
                    {
                        int withdrawAmount = rnd.Next(_minWithdrawAmount, _maxWithdrawAmount + 1);

                        WithdrawNotif();
                        Thread.Sleep(100);

                        if (CurrBalance < withdrawAmount)
                        {
                            Console.WriteLine("Недостаточно средств");
                        }
                        else
                        {
                            CurrBalance -= withdrawAmount;
                        }

                        Thread.Sleep(100);
                    }

                }
                else
                {
                    Console.WriteLine("Данная запись не является числом");
                }
            }
        }

        private void WithdrawNotif() => Console.WriteLine("Пытаемся снять деньги с банкомата");
    }
}
