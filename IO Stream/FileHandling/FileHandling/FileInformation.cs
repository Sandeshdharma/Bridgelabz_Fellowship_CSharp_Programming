using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace FileHandling
{
     class FileInformation
    {
        public void FileCompleteDetails()
        {
            FileInfo file = new FileInfo("data.txt");
            Console.WriteLine(file.Length);
            Console.WriteLine(file.Name);
            Console.WriteLine(file.CreationTime);

           
        }
    }
}
