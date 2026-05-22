using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SQLConnectionADO
{
    class create
    {
        public void CreateTable()
        {
        
            SqlConnection con = new SqlConnection(
            "Server=localhost;Database=Student_Details;Integrated Security=True;TrustServerCertificate=True");

 
            string query = "create table Student(Name varchar(50), RollNumber int, Email varchar(50), PhoneNumber varchar(15))";

   
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            cmd.ExecuteNonQuery();

            Console.WriteLine("Table Created Successfully");

            con.Close();
        }
    }
}
