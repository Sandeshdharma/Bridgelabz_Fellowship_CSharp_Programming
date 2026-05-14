using System;

namespace AnnotationDemo
{
   
    public class oldApi
    {
      
        [Obsolete("dont use this is old")]
        public void OldFeature()
        {
            Console.WriteLine("Executing Old Feature logic");
        }

        public void NewFeature()
        {
            Console.WriteLine("Executing New, Optimized Feature logic!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            oldApi api = new oldApi();

           
            Console.WriteLine("--- Calling New Feature ---");
            api.NewFeature();

            Console.WriteLine("\n--- Calling Old Feature ---");
            api.OldFeature(); 

            Console.ReadLine();
        }
    }
}