using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Carsharing
{
    class SqlDatabase
    {
        private string dataSource;
        private SQLiteConnection connection;
        private SQLiteCommand command;

        public SqlDatabase(string databaseName)
        {
        //SQLLite Datenbank
        dataSource = "databaseName";
        connection = new SQLiteConnection();

        connection.ConnectionString = "Data Source" + dataSource;
        connection.Open();

        command = new SQLiteCommand(connection);
        // Erstellen der Tabelle, sofern diese noch nicht existiert.
        command.CommandText = "CREATE TABLE IF NOT EXISTS T_LenderCar ( p_f_lenderId INTEGER NOT NULL PRIMARY KEY, p_f_licenseTag VARCHAR(10) NOT            NULL PRIMARY KEY); CREATE TABLE IF NOT EXISTS T_CAR (p_licenseTag VARCHAR(10) NOT NULL PRIMARY KEY, model VARCHAR(200), manufacturer VARCHAR(200), priceperDay DECIMAL); CREATE TABLE IF NOT EXISTS T_Lender (p_lenderId INTEGER NOT NULL PRIMARY KEY, name VARCHAR(50), age INTEGER, adress VARCHAR(200));";
        command.ExecuteNonQuery();

        // Einfügen eines Test-Datensatzes.
        command.CommandText = "INSERT INTO beispiel (id, name) VALUES(NULL, 'Test-Datensatz!')";
        command.ExecuteNonQuery();

        // Freigabe der Ressourcen.
        command.Dispose();
        }

        public void insertLender()
        {
            // Einfügen eines Test-Datensatzes.
            command.CommandText = "INSERT INTO beispiel (id, name) VALUES(NULL, 'Test-Datensatz!')";
            command.ExecuteNonQuery();

            // Freigabe der Ressourcen.
            command.Dispose();
        }

        public SQLiteConnection getConnection()
        {
            return connection;
        }
    }
}
