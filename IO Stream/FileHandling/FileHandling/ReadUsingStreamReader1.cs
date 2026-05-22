using System;
using System.Collections.Generic;
using System.Text;

namespace FileHandling
{
    class ReadUsingStreamReader1
    {

        public void Read()
        {
            string path = @"C:\Users\91638\Desktop\C_Sharp_Dot_Net\IO Stream\FileHandling\File1.txt";
            string data;

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

            using (StreamReader sr = new StreamReader(fs))
            {

                data = sr.ReadToEnd();


            }
            Console.WriteLine(data);
            Console.ReadLine();



        }
    }
}
