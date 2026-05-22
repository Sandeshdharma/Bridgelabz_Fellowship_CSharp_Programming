using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace SQLConnectionADO
{
     class ReadNew
    {

        public void Read()
        {
            SqlConnection con = new SqlConnection("server=localhost; database= StudentInfo; Integrated Security= True; TrustServerCertificate= True");
            string query = "Select * from StudentData";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader Reader = cmd.ExecuteReader();

            while (Reader.Read())
            {
                Console.WriteLine(
                    Reader["Id"] + " " +
                    Reader["Name"] + " " +
                    Reader["Section"] + " " +
                    Reader["PhoneNo"] + " ");




                    


            }
            con.Close();



        }
    }
}

