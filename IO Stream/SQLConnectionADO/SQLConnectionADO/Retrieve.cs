using System;
using System.Text;
using System.Data.SqlClient;
using System.Globalization;

namespace SQLConnectionADO
{
     class Retrieve
    {
        public void ViewData()
        {
            SqlConnection con = new SqlConnection("Server=localhost;Database=Student_Details;Integrated Security = True; TrustServerCertificate = True");
            String query = "select * from Student";
            SqlCommand cmd = new SqlCommand(query , con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Name: {reader["Name"]}, Roll: {reader["RollNumber"]}, Email: {reader["Email"]}, Phone: {reader["PhoneNumber"]}");
            }
            con.Close();
            Console.WriteLine("data fetch sucessfully");



        }
    }
}
