using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace FileHandling
{
     class DirectoryCreation
    {

        public void CreateDirectory()
        {
            if (Directory.Exists("Sandesh-Data"))
            {
                Console.WriteLine("exist folder");
            }
            else
            {
                Console.WriteLine("not exiswt");
            }
            
        }
    }
}
