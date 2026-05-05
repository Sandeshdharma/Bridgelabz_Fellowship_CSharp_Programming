namespace Generic
{
    class Example
    {
        public static void ShowArray<T>(T[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]); 
            }
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[3];
            Numbers[0] = 11;
            Numbers[1] = 22;
            Numbers[2] = 33;


            string[] Names = { "sandesh", "raj", "Anu" };
            Example.ShowArray(Numbers);
            Example.ShowArray(Names);

            Console.ReadLine();

        }
    }
}
