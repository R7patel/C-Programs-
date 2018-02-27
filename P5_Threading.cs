using System;
using System.Threading;

namespace ConsoleApplication5
{
    class Program
    {

        public static void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("IN RUN::" + Thread.CurrentThread.Name + "Count::"+i);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("AAA" + Thread.CurrentThread);
            Thread t = Thread.CurrentThread;
            Thread.CurrentThread.Name = "MAIN";
            Thread.CurrentThread.Priority = ThreadPriority.Lowest;
            Console.WriteLine("AA3" + t);
            ThreadStart ts = new ThreadStart(Run);
            Console.WriteLine("AA4");
            Thread th = new Thread(ts);
            th.Name = "Thread 1";
            Thread th1 = new Thread(ts);
            th1.Name = "Thread 2";
            th.Priority = ThreadPriority.Lowest;
            th1.Priority = ThreadPriority.Highest;
            th.Start();
            th1.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("IN RUN::" + Thread.CurrentThread.Name + "Count::" + i);
            }
            th1.Join();
            th.Join();
        }
    }
}
