using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;//ist vorübergehend nur zum Testen

namespace Carsharing
{
    class Database : IDatabase
    {
        private string dataSource;
        private SQLiteConnection connection;
        private SQLiteCommand command;

        // Parameterisierter Konstruktor
        public Database(string databaseName)
        {
            // SQLite Datenbank anbindung
            this.dataSource = databaseName;
            this.connection = new SQLiteConnection();
            this.connection.ConnectionString = "Data Source=" + dataSource;
            this.connection.Open();
            this.command = new SQLiteCommand(this.connection);

            // Erstellen der Tabelle, sofern diese noch nicht existiert.
            try
            {
                this.command.CommandText = "CREATE TABLE IF NOT EXISTS T_Carsharing (p_branchNo INTEGER PRIMARY KEY, name VARCHAR(50), adress VARCHAR(200)); CREATE TABLE IF NOT EXISTS T_LenderCar (p_f_lenderId INTEGER NOT NULL, p_f_licenseTag VARCHAR(8) NOT NULL, PRIMARY KEY (p_f_lenderId, p_f_licenseTag) FOREIGN KEY (p_f_lenderId) REFERENCES T_Lender (p_lenderId) ON UPDATE CASCADE ON DELETE NO ACTION, FOREIGN KEY (p_f_licenseTag) REFERENCES T_Car (P_licenseTag) ON UPDATE CASCADE ON DELETE NO ACTION ); CREATE TABLE IF NOT EXISTS T_Car (p_licenseTag VARCHAR(8) NOT NULL PRIMARY KEY, model VARCHAR(200), manufacturer VARCHAR(200), priceperDay DECIMAL, p_f_branchNo INTEGER DEFAULT NULL, FOREIGN KEY (p_f_branchNo) REFERENCES T_Carsharing (p_branchNo) ON UPDATE CASCADE ON DELETE SET NULL );  CREATE TABLE IF NOT EXISTS T_Lender (p_lenderId INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, name VARCHAR(50), age INTEGER, adress VARCHAR(200));";
                this.command.ExecuteNonQuery();
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
            // Lade Daten aus der Datenbank
            LoadData();
            // Instanzierung der Klassen anhand der Einträge in der Datenbank
            if (connection.State == ConnectionState.Open)
                connection.Close();
            command.Dispose();
        }

        public DataSet LoadData()
        {
            try
            {
                // Erstellen der benötigten Tabellen
                DataTable t_carsharing = new DataTable("T_Carsharing");
                DataTable t_lender = new DataTable("T_Lender");
                DataTable t_car = new DataTable("T_Car");
                DataTable t_lendercar = new DataTable("T_LenderCar");

                // DataAdapter mit SELECT Befehl für Tabelle T_Carsharing
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT p_branchNo, name, adress FROM T_Carsharing", this.connection);
                // Befüllen der Tabelle
                dataAdapter.Fill(t_carsharing);
                // Ressourcenfreigabe
                dataAdapter.Dispose();

                // DataAdapter mit SELECT Befehl für Tabelle T_Lender
                dataAdapter = new SQLiteDataAdapter("SELECT p_lenderID, name, age, adress FROM T_Lender", this.connection);
                dataAdapter.Fill(t_lender);
                dataAdapter.Dispose();

                // DataAdapter mit SELECT Befehl für Tabelle T_Car
                dataAdapter = new SQLiteDataAdapter("SELECT p_licenseTag, model, manufacturer, pricePerDay, p_f_branchNo FROM T_Car", this.connection);
                dataAdapter.Fill(t_car);
                dataAdapter.Dispose();

                // DataAdapter mit SELECT Befehl für Tabelle T_LenderCar
                dataAdapter = new SQLiteDataAdapter("SELECT p_f_lenderId, p_f_licenseTag FROM T_LenderCar", this.connection);
                dataAdapter.Fill(t_lendercar);
                dataAdapter.Dispose();
                connection.Close();
                // Erstellen und Füllen des DataSet's
                DataSet carsharingData = new DataSet("CarsharingData");
                carsharingData.Tables.Add(t_carsharing);
                carsharingData.Tables.Add(t_lender);
                carsharingData.Tables.Add(t_car);
                carsharingData.Tables.Add(t_lendercar);

                return carsharingData;
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
        }

        // Auto Ausleihen
        public void InsertLending(int lenderId, string licenseTag) //Done but not tested
        {
            string Sqltext = "INSERT INTO T_LenderCar (p_f_lenderId, p_f_licenseTag) VALUES('" + lenderId + "','" + licenseTag + "')";
            this.executeSqlString(Sqltext);
        }

        //Ausleihe Löschen
        public void RemoveLending(int lenderId, string licenseTag)
        {
            string Sqltext = "DELETE FROM T_LenderCar WHERE p_f_lenderId = " + lenderId + " AND p_f_licenseTag = " + "'" + licenseTag + "'";
            this.executeSqlString(Sqltext);
        }

        // Niederlassun hinzufügen
        public void CreateBranch(string name, string adress)
        {
            string Sqltext = "INSERT INTO T_Carsharing (name, adress) VALUES('" + name + "','" + adress + "');";
            this.executeSqlString(Sqltext);
        }

        // Niederlassung entfernen
        public void RemoveBranch(int branchNo)
        {
            string Sqltext = "DELETE FROM T_Carsharing WHERE p_branchNo = " + branchNo + ");";
            this.executeSqlString(Sqltext);
        }

        // Mieter anlegen   
        public void CreateLender(string name, int age, string adress)
        {
            string Sqltext = "INSERT INTO T_Lender (name, age, adress) VALUES('" + name + "','" + age + "','" + adress + "');";
            this.executeSqlString(Sqltext);
        }

        // Mieter löschen
        public void RemoveLender(int lenderId)
        {
            List<string> licenseTags = GetRentedCars(lenderId);
            if (licenseTags.Count < 1)
            {
                string Sqltext = "DELETE FROM T_Lender WHERE p_lenderId = " + lenderId.ToString() + ";";
                this.executeSqlString(Sqltext);
            }
            else
                throw new Exception("Der Benutzer hat noch Autos ausgeliehen und kann deswegen nicht gelöscht werden.");
        }
        // Mieter anzeigen - wird das überhaupt genutzt?
        public void ShowLender(int lenderID)
        {
            string Sqltext = "SELECT * FROM T_Lender WHERE p_lenderId = " + lenderID + ";";
            this.executeSqlString(Sqltext);
        }

        // Auto erstellen
        public void CreateCar(string licenseTag, string model, string manufacturer, decimal pricePerDay, int assignedBranchNo)
        {
            string Sqltext = "INSERT INTO T_Car (p_licenseTag, model, manufacturer, priceperDay, p_f_branchNo) VALUES('" + licenseTag + "','" + model + "','" + manufacturer + "','" + pricePerDay + "','" + assignedBranchNo + "');";
            this.executeSqlString(Sqltext);
        }

        // Auto löschen 
        public void RemoveCar(string licenseTag)
        {
            string Sqltext = "DELETE FROM T_Car WHERE p_licenseTag = '" + licenseTag + "';";
            this.executeSqlString(Sqltext);
        }
        // Ausgeliehene Autos pro Mieter - gibt eine String-Liste der jeweiligen Nummernschilder aus 
        public List<string> GetRentedCars(int lenderID)//DONE
        {
            try
            {
                command = new SQLiteCommand(this.connection);
                command.CommandText = "SELECT p_f_licenseTag FROM T_LenderCar WHERE p_f_lenderId = " + lenderID;
                List<string> licenseTagList = new List<string>();
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        licenseTagList.Add(Convert.ToString(reader["p_f_licenseTag"]));
                    }
                }
                connection.Close();
                command.Dispose();
                reader.Dispose();
                return licenseTagList;
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
        }
        // Liste mit allen ausgeliehenen Fahrzeugen
        public List<string> GetAllRentedCars()
        {
            try
            {
                command = new SQLiteCommand(this.connection);
                command.CommandText = "SELECT p_f_licenseTag From T_LenderCar;";
                List<string> licenseTagList = new List<string>();
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        licenseTagList.Add(Convert.ToString(reader["p_f_licenseTag"]));
                    }
                }
                return licenseTagList;
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }

        }
        // Für alle SQL Befehle
        public void executeSqlString(string SqlString)
        {
            try
            {
                command = new SQLiteCommand(this.connection);
                command.CommandText = SqlString;
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (SQLiteException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}

