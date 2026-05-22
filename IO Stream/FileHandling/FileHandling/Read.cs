using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileHandling
{
     class Read
    {
        public void ReadContent()
        {
            if (File.Exists("data.txt"))
            {
                string content = File.ReadAllText("data.txt");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
     
    }
}
