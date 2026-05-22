using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SQLConnectionADO
{
     class Update
    {

        public void UpdateData()
        {
            SqlConnection con = new SqlConnection("server=localhost; database= StudentInfo; Integrated Security= True; TrustServerCertificate= True");
            string query = "UPDATE StudentData  SET ID= '4' where Name ='anshika'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data updated");
            con.Close();

        }
    }
}
