using Multithreading;
using System;

namespace ThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Main Thread Started");

            //// 1. Create an instance of the class from multi1.cs
            //ThreadRunner runner = new ThreadRunner();

            //// 2. Call the method to trigger your threads
            //runner.ExecuteMultiThreading();

            //Console.WriteLine("Main Thread Ended");
            //Console.Read();

            //SleepThread1 ST = new SleepThread1();
            //ST.Method1();
            //ST.Method2();
            //ST.Method3();
            //Console.ReadLine();

            //MultiThread MT = new MultiThread();
            //MT.CreateThread();
            //Console.ReadLine();

            //StartThreadDelegates ST = new StartThreadDelegates();
            //ST.StartThd();
            //Console.ReadLine();

            //LockKeyWord LK = new LockKeyWord();
            //LK.Somemethod();
            //Console.ReadLine();


            //LockDisplayMethod LS = new LockDisplayMethod();
            //LS.display();
            //Console.ReadLine();
            Deadlock d = new Deadlock();

            Thread t = new Thread(d.thread1);
            Thread t2 = new Thread(d.thread2);
            t.Start();
            t2.Start();
            t.Join();
            Console.ReadLine();

        

        }
    }
}