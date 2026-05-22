using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace FileHandling
{
     class Append2
    {

        public void newAppend()
        {
            string path = @"C:\Users\91638\Desktop\C_Sharp_Dot_Net\IO Stream\FileHandling\NewFile.txt";

            FileStream fs = new FileStream(path, FileMode.Append);
            byte[] byteArr = Encoding.Default.GetBytes("i am now adding some more lines in my existing file\n where i learn how to append new data in existing files ");
            fs.Write(byteArr, 0, byteArr.Length);
            fs.Close();
            Console.WriteLine("add new lines succesfully");
            Console.ReadKey();
        }
    }
}
