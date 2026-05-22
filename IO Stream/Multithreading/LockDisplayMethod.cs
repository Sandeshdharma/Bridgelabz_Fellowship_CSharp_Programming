using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Multithreading
{
     class LockDisplayMethod
    {

        public void lockDisplay()
        {
            Thread T1 = new Thread(display)
            {
                Name = "Threa1"
            };
            Thread T2 = new Thread(display)
            {
                Name = "Thread2"
            };
            Thread T3 = new Thread(display)
            {
                Name = "Thread3"
            };

            T1.Start();
            T2.Start();
            T3.Start();
            Console.ReadLine();


        }
        private static readonly object Displayobject = new object();
        public void display()
        {
            lock (Displayobject)
            {
                Console.Write("welocme");
                Thread.Sleep(10000);
                Console.WriteLine("to the Gla University");

            }
        }

       
    }
}
