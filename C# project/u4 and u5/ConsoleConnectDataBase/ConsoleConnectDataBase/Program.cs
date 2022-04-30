using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;

namespace ConsoleConnectDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\c#\ConsoleConnectDataBase\ConsoleConnectDataBase\ConsoleData.mdf;Integrated Security=True;User Instance=True");
            conn.Open();
            
            Console.WriteLine("Enter user name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter user Password: ");
            string pass = Console.ReadLine();
            SqlCommand cmd1 = new SqlCommand("insert into user_detail values(@name, @pass)", conn);
            cmd1.Parameters.AddWithValue("@name","name");
            cmd1.Parameters.AddWithValue("@password","pass");
            Console.WriteLine("Name:" + name + "\n" + "Password: " + pass);
            SqlCommand cmd = new SqlCommand("select * from user_detail", conn);
            cmd.ExecuteNonQuery();
            SqlDataReader rdr = cmd.ExecuteReader();
            Console.WriteLine("___User Details____");
            while (rdr.Read())
            {
                Console.Write("Uer Name: "+rdr["name"].ToString() + "\n"+"User Password: "+ rdr["password"].ToString());
            }
            Console.ReadLine();
        }
    }
}
