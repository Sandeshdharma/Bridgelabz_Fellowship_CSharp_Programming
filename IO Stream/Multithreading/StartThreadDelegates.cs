using System;
using System.Collections.Generic;
using System.Text;

namespace Multithreading
{
     class StartThreadDelegates
    {

        public void StartThd()
        {
            ThreadStart obj = new ThreadStart(printnumber);
            Thread T1 = new Thread(obj);
            T1.Start();

          
        }
        public void printnumber()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("numbers:" + i);
            }
        }
    }
}
