using AnnotationDemo;
using System;
using System.Collections.Generic;
using System.Text;


namespace Annotation
{
    internal class Program
    {
        public static void Main()
        //{
        //    Obsolete Ob = new Obsolete();
        //    Ob.oldMethod();
        //    Console.ReadLine();
        //}

        {
            oldApi api = new oldApi();


            Console.WriteLine(" Calling New Feature ");
            api.NewFeature();

            Console.WriteLine(" Calling Old Feature ");
            api.OldFeature();


            Console.ReadLine();
        }
    }
}
