using System;
using System.Data.SQLite;

namespace SQLiteCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadCountries();
        }
        private static void ReadCountries()
        {
            DataBase dataBaseObj = new DataBase();
            string query = "SELECT Country.countryName AS Country, Capital.capitalName AS Capital FROM Capital, JOIN Country ON Capital.countryID = Country.rowid";
            SQLiteCommand myCommand = new SQLiteCommand(query, dataBaseObj.myConnection);
            dataBaseObj.OpenConnection();
            SQLiteDataReader data = myCommand.ExecuteReader();
            if (data.HasRows)
            {
                while (data.Read())
                {
                    Console.WriteLine($"Country: {data["Country"]}. Capital: {data["Capital"]}");
                }
            }
            dataBaseObj.ClosedConnection();
        }

    }
}
