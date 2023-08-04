using MySql.Data.MySqlClient;

namespace FormRegLogin
{
    class DataBase
    {
        MySqlConnection conn = new MySqlConnection("server= localhost; port = 3306; username = root; password = root; database = reglogmysql");

        public void openConnection() 
        { 
            if(conn.State == System.Data.ConnectionState.Closed) 
            {
                conn.Open();
            }
        }
        public void closedConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public MySqlConnection getConnection() 
        {
            return conn;
        }
    }
}
