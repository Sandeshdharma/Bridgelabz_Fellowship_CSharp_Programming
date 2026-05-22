using System;
using System.Collections.Generic;
using System.Text;

namespace Multithreading
{
    internal class Deadlock
    {
        static readonly object lock1 = new object();
        static readonly object lock2 = new object();
        public void thread1()
        {
            lock(lock1)
            {
                Console.WriteLine("thread 1 acquire lock1");
                Thread.Sleep(5000);
                lock (lock2)
                {
                    Console.WriteLine("thread 1 acquire lock2");
                }
            }
        }
        public void thread2()
        {
            lock (lock1)
            {
                Console.WriteLine("thread 2 acquire lock2");
                Thread.Sleep(5000);
                lock (lock2)
                {
                    Console.WriteLine("thread 2 acquire lock1");
                }
            }
        }


    }
}
