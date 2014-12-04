using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Carsharing
{
    class Database : IDatabase
    {
        private string dataSource;
        private SQLiteConnection connection;
        private SQLiteCommand command;

        public Database(string databaseName)
             
        {
        //SQLLite Datenbank
        dataSource = databaseName;
        connection = new SQLiteConnection();

        connection.ConnectionString = "Data Source=" + dataSource;
        Console.WriteLine(connection.ConnectionString);
        connection.Open();

        command = new SQLiteCommand(connection);
        // Erstellen der Tabelle, sofern diese noch nicht existiert.
        command.CommandText = "CREATE TABLE IF NOT EXISTS T_LenderCar (p_f_lenderId INTEGER NOT NULL, p_f_licenseTag VARCHAR(10) NOT NULL, PRIMARY KEY (p_f_lenderId, p_f_licenseTag)); CREATE TABLE IF NOT EXISTS T_CAR (p_licenseTag VARCHAR(10) NOT NULL PRIMARY KEY, model VARCHAR(200), manufacturer VARCHAR(200), priceperDay DECIMAL); CREATE TABLE IF NOT EXISTS T_Lender (p_lenderId INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, name VARCHAR(50), age INTEGER, adress VARCHAR(200));";
        command.ExecuteNonQuery();
        }

        public void loadData()
        {
            command = new SQLiteCommand(connection);
            // Auslesen des zuletzt eingefügten Datensatzes.
            command.CommandText = "SELECT p_lenderId, name, age, adress FROM T_Lender ORDER BY p_lenderId";

            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                //TODO: Artem
                //Console.WriteLine("Dies ist der {0}. eingefügte Datensatz mit dem Wert: \"{1}\"", reader[0].ToString(), reader[1].ToString());
                //Console.ReadLine();
            }

            // Beenden des Readers und Freigabe aller Ressourcen.
            reader.Close();
            reader.Dispose();

            command.Dispose();        
        }

        //Auto Ausleihen
        public void insertLending(int lenderId, string licenseTag)
        {
            //TODO: Artem
        }
        //Ausleihe Löschen
        public void removeLending(int lenderId, string licenseTag)
        {
            //TODO: Artem
        }
        //Mieter anlegen
        public void createLender(string name, int age, string adress)
        {
            command = new SQLiteCommand(connection);
            // Einfügen eines Datensatzes
            command.CommandText = "INSERT INTO T_Lender (name, age, adress) VALUES('"+ name + "','" + age + "','" + adress + "')";
            command.ExecuteNonQuery();

            // Freigabe der Ressourcen.
            command.Dispose();
        }
        //Mieter löschen
        public void removeLender(Lender lender)
        {
            command = new SQLiteCommand(connection);
            List<string> licenseTags = getRentedCars(lender.getLenderId());
            if ((lender.isRemovable(lender, licenseTags)) == true)
            {
                command.CommandText = "DELETE FROM T_Lender WHERE [p_lenderID ="+ lender.getLenderId() +"];";
                command.ExecuteNonQuery();

                // Freigabe der Ressourcen.
                command.Dispose();
            }
            else 
                throw new Exception("Der Benutzer hat noch Autos ausgeliehen und kann deswegen nicht gelöscht werden.");
            
        }
        //Mieter löschen
        public void showLender(int lenderID)
        {
            //TODO: Artem
        }
        //Auto erstellen
        public void createCar(string licenseTag, string model, string manufacturer, decimal pricePerDay)
        {
            //TODO: Artem
        }
        //Auto löschen 
        public void deleteCar(string licenseTag)
        {
            //TODO: Artem
        }
        //Ausgeliehene Autos pro Mieter 
        public List<string> getRentedCars(int lenderID)
        {
            List<string> licenseTagList = new List<string> {
                //TODO:arteeeeem fuell das mit der liste von eliehenen autos pro lenderid auf
            };
            
            return licenseTagList;
        }
    }
}
