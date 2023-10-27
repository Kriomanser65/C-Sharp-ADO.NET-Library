using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection("Data Source = DESKTOP - 4SK39GD; Initial Catalog = ITacademy; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False");
            try
            {
                connection.Open();
                string query = "insert into [dbo].[ITacademy](Name,Debt,BookHave,Author) values";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            finally
            {
                connection?.Close();
            }
        }
    }
}
//create table Clients
//(
//Id int primary key identity(1,1),
//Name nvarchar(100) not null,
//Debt nvarchar(50) not null,
//BookHave int not null
//)
//create table Books
//(
//Id int primary key identity(1,1),
//Name nvarchar(100) not null,
//Author nvarchar(100) not null
//)