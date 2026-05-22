using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace FileHandling
{
     class WriteUsingStreamWriter
    {

        public void Write()
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\91638\Desktop\C_Sharp_Dot_Net\IO Stream\FileHandling\NewFile.txt");
            Console.WriteLine("Enter the text that you want to write  in the file");

            string inputdata = Console.ReadLine();
            sw.Write(inputdata);
            Console.WriteLine("data has been enterted");
            sw.Flush();
            sw.Close();
            Console.ReadKey();




        }
    }
}
