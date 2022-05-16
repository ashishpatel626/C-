using System.Collections.Generic;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            for(int i = 0; i <10; i++)
            {
                Console.WriteLine(num);
                Thread.Sleep(1000);
                num++;
            }
            Console.WriteLine("Thread Ends");
        }
    }

    class BankAcct
    {
        private Object acctLock = new Object();
        double Balance  {set; get;}

        public BankAcct(double bal)
        {
            Balance = bal;
        }

        public double Withdraw (double amt)
        {
            if((Balance - amt) < 0)
        }
    }
}