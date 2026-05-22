using System;
using System.Collections.Generic;
using System.Text;

namespace FileHandling
{
     class Create
    {

        public void createfile()
        {

            string path = @"C:\Users\91638\Desktop\C_Sharp_Dot_Net\IO Stream\FileHandling\File2.txt";

            FileStream fs = new FileStream(path, FileMode.Create);

            fs.Close();
            Console.WriteLine("created");
            Console.ReadLine();





        }
    }
}
