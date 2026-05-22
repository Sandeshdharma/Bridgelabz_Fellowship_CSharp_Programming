using System;
using System.Xml.Linq;


namespace SQLConnectionADO
{
    class Program
    {
        static void Main(string[] args)
        {
            //create obj = new create();

            //obj.CreateTable();

            //Console.ReadKey();

            //Insert obj = new Insert();

            //obj.insertdata();

            //Console.ReadLine();

            //Retrieve obj = new Retrieve();
            //obj.ViewData();
            //Console.ReadLine();


            //Delete obj = new Delete();
            //obj.DeleteData();
            //Console.ReadLine();

            //CreateNew TB = new CreateNew();
            //TB.CreateNewTable();
            //Console.ReadLine();


            //InsertNew IN = new InsertNew();
            //IN.insertdata();
            //Console.ReadLine();

            //ReadNew rd = new ReadNew();
            //rd.Read();
            //Console.ReadLine();


            //Update upt = new Update();
            //upt.UpdateData();
            //Console.ReadLine();


            DeleteNew DT = new DeleteNew();
            DT.DeleteOne();
            Console.ReadLine();
        }
    }
}