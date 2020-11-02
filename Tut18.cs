using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
//Threads
namespace DerekBanasCSharpTut
{
    class BankAccount
    {
        private Object acctLock = new object();
        double Balance { get; set; }
        public BankAccount(double bal)
        {
            Balance = bal;
        }
        public double Withdraw(double amt)
        {
            if((Balance - amt) < 0)
            {
                Console.WriteLine("Sorry,balance is {0}", Balance);
                return Balance;
            }
            //it will block any other threads from accessing the block of code here
            //untill each thread under this block finishes its execution
            lock (acctLock)
            {
               if(Balance >= amt)
                {
                    Console.WriteLine("Withdrawed : {0} and {1} left", amt, Balance-amt);
                    Balance -= amt;
                }
                return Balance;
            }
        }
        public void IssueWithdraw()
        {
            Withdraw(1);
        }

    }
    class Tut18
    {
        public static void Sample(string[] args)
        {
            BankAccount account = new BankAccount(10);
            Thread[] threads = new Thread[15];
            Thread.CurrentThread.Name = "main";
            for(int i = 0; i < 15; i++)
            {
                Thread t = new Thread(new ThreadStart(account.IssueWithdraw));
                t.Name = i.ToString();
                threads[i] = t;
            }
            for(int i = 0; i < 15; i++)
            {
                Console.WriteLine("Thread {0} is alive ? {1}", threads[i].Name,
                    threads[i].IsAlive);
                threads[i].Start();
                Console.WriteLine("Thread {0} is alive ? {1}", threads[i].Name,
                    threads[i].IsAlive);
            }
            Console.WriteLine("Current Priority : {0}", Thread.CurrentThread.Priority);
            Console.WriteLine("Thread : {0} ending...", Thread.CurrentThread.Name);
            
        }
    }
}
