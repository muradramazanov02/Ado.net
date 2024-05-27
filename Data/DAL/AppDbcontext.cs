using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL
{
    public class AppDbcontext
    {
        string conString = "Server=DESKTOP-IVL046S\\SQLEXPRESS;Database=AB204AdoNet;Trusted_Connection=true;Integrated Security=true;TrustServerCertificate=true;";
        public SqlConnection sqlConnection;

        public AppDbcontext()
        {
            sqlConnection = new SqlConnection(conString);
        }

        public void NonQuerry(string command)
        {
            sqlConnection.Open(); 

            SqlCommand sqlCommand= new SqlCommand(command,sqlConnection);
            var result= sqlCommand.ExecuteNonQuery();

            if(result>0)
            {
                Console.WriteLine("Completed successfully:" + result);
            }
            else
            {
                Console.WriteLine("Something went wrong!");
            }
            
            sqlConnection.Close();
        }

        public DataTable Querry(string selectCommand)
        {
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter=new SqlDataAdapter(selectCommand,sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            

            sqlConnection.Close();

            return dataTable;
        }
    }
}
