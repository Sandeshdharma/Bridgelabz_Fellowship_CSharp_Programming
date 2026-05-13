using System;
using System.Collections.Generic;

namespace Delegates_2
{
    public delegate void calculation(int a , int b);
    internal class Program
    {
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("addition result is {0}", result);
        }

        public static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("subtraction result is {0}", result);
        }
        public static void multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("multiplication result is {0}", result);
        }
        public static void division(int a, int b)
        {
            int result = a/b;
            Console.WriteLine("division result is {0}", result);
        }
        static void Main(string[] args)
        {

            calculation obj = new calculation(Program.Addition);
            obj.Invoke(20, 30);
            obj = Subtraction;
            obj(20, 10);
            obj = multiplication;
            obj(30,40);
            obj = division;
            obj(500, 60);
            Console.ReadLine();
            

        }
    }
}
