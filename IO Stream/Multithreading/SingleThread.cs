using System;
using System.Collections.Generic;
using System.Text;

namespace Multithreading
{
    internal class SingleThread
    {
        public void Method_slp1()
        {

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method1" + i);
            }

        }
        public void Method_slp2()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("method2" + i);
            }
        }
        public void Method_slp3()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("method3" + i);
            }
        }

    }
}
