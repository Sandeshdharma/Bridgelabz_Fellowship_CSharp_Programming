using System;
using System.Collections.Generic;
using System.Text;


namespace Annotation
{
    internal class Program
    {
        public static void Main()
        {
            Obsolete Ob = new Obsolete();
            Ob.oldMethod();
            Console.ReadLine();
        }
    }
}
