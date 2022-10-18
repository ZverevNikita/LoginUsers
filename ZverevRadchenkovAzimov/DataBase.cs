using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ZverevRadchenkovAzimov
{
    class DataBase
    {
        SqlConnection sqlconnection = new SqlConnection(@"Data Source=LAPTOP-NO79S9UJ\SQLEXPRESS; Initial Catalog = Shop; Integrated Security=True");
        public void openConnection()
        {
            if (sqlconnection.State == System.Data.ConnectionState.Closed)
            {
                sqlconnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlconnection.State == System.Data.ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return sqlconnection;
        }
    }
}
