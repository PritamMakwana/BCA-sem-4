using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace _DataTable_class_Demo

{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ksc\AppData\Local\Temporary Projects\_DataTable_class_Demo\dbdemo.mdf;Integrated Security=True;User Instance=True");
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from user_detail", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine(dt.Rows[i][0].ToString() + " " +
                    dt.Rows[i][1].ToString());
            }

            Console.ReadLine();

        }
    }
}
