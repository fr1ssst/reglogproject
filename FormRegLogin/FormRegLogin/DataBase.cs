using MySql.Data.MySqlClient;

namespace FormRegLogin
{
    class DataBase
    {
        MySqlConnection connection = new MySqlConnection("server= localhost; port = 3306; username = root; password = root; database = reglogmysql");

        public void openConnection() 
        { 
            if(connection.State == System.Data.ConnectionState.Closed) 
            {
                connection.Open();
            }
        }
        public void closedConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection getConnection() 
        {
            return connection;
        }
    }
}
