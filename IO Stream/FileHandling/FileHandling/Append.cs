using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace FileHandling
{
    class Append
    {
        public void Appenddata()
        {

            if (File.Exists("data.txt"))
            {
                File.AppendAllText("data.txt", "new lines append in the file data");
                Console.WriteLine("Appended");

            }
            else
            {
                Console.WriteLine("file not found");
            }
          
            

        }

    
    }
}
