using System;
using System.Collections.Generic;
using System.Text;

namespace FileHandling
{
     class WriteusingFileStream
    {

        public void WriteTxt()
        {
            string path = @"C:\Users\91638\Desktop\C_Sharp_Dot_Net\IO Stream\FileHandling\TextFile1.txt";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write);

            byte[] byteArr = Encoding.Default.GetBytes("write usng write");
            fs.Write(byteArr, 0, byteArr.Length);
            fs.Close();
            Console.WriteLine("written new lines ");
            Console.ReadKey();

        }
    }
}
