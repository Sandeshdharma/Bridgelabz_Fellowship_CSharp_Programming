using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace SQLConnectionADO
{
    class Delete
    {


        public void DeleteData()
        {
            SqlConnection con = new SqlConnection("Server = localhost; Database= Student_Details; Integrated Security = True; TrustServerCertificate= True");

            string query = "delete from Student where RollNumber ='57'";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Record Deleted Successfully");



        }
    }
}
