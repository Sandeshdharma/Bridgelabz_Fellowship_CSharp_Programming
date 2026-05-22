using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SQLConnectionADO
{
     class DeleteNew
    {

        public void DeleteOne()
        {
            SqlConnection con = new SqlConnection("server=localhost; database= StudentInfo; Integrated Security= True; TrustServerCertificate= True");

            string query = "Delete from StudentData where ID =3";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            
            Console.WriteLine("Data Deleted from the table");
            con.Close();
        }
    }
}
