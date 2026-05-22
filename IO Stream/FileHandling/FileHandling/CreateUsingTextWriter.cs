using System;
using System.Collections.Generic;
using System.Text;

namespace FileHandling
{
    class CreateUsingTextWriter
    {

        public void Create()
        {
            string path = @"C:\Users\91638\Desktop\C_Sharp_Dot_Net\IO Stream\FileHandling\TextFile.txt";
            using(TextWriter TW = File.CreateText(path))
            {
                TW.WriteLine("hello");
                TW.WriteLine("done");
            }
            Console.WriteLine("succesfully");
        }

    }
}
