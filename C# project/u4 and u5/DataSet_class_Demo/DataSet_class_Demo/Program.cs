using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataSet_class_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ksc\AppData\Local\Temporary Projects\DataSet_class_Demo\DataDemo.mdf;Integrated Security=True;User Instance=True");
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from stud", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "stud");

            SqlDataAdapter da2 = new SqlDataAdapter("select * from emp", con);
            DataSet ds2 = new DataSet();
            da.Fill(ds2, "emp");

            Console.WriteLine("==stud==");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Console.WriteLine(ds.Tables[0].Rows[i][0].ToString() + "" +
                    ds.Tables[0].Rows[i][1].ToString());
            }

            Console.WriteLine("==emp==");
            for (int j = 0; j < ds2.Tables[0].Rows.Count; j++)
            {
                Console.WriteLine(ds2.Tables[0].Rows[j][0].ToString() + "" +
                    ds2.Tables[0].Rows[j][1].ToString());

            }


            Console.ReadLine();
        }
    }
}
