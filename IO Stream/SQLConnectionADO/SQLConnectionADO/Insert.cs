using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SQLConnectionADO
{
    class Insert
    {
        public void insertdata()
        {
            SqlConnection con = new SqlConnection("Server= localhost; Database = Student_Details; Integrated Security=True; TrustServerCertificate= True");

            string query = "insert into Student(Name, RollNumber, Email, PhoneNumber) values ('Sandesh', '57', 'sandeshsri01@gmail.com', '6388694107'), ('Tushar', '58', 'tushar12@gmail.com', '9307827538')";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("inserted success");
        }
    }
}
