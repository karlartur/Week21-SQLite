using System;
using System.Data.SQLite;


namespace SQLiteCountries
{
    class DataBase
    {
        public SQLiteConnection myConnection;
        public DataBase()
        {
            myConnection = new SQLiteConnection("Data source=SQLiteCountries.db");

        }
        public void OpenConnection()
        {
            if(myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }
        public void ClosedConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }
    }
}
