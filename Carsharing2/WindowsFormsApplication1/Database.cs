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

        //parameterisierter Konstruktor
        public Database(string databaseName)
        {
            //SQLite Datenbank
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
            //Lade Daten aus der Datenbank
            LoadData();
            //Instanzierung der Klassen anhand der Einträge in der Datenbank
            if (connection.State == ConnectionState.Open)
                connection.Close();
            command.Dispose();
        }

        public DataSet LoadData()
        {
            try
            {
                //Erstellen der benötigten Tabellen
                DataTable t_carsharing = new DataTable("T_Carsharing");
                DataTable t_lender = new DataTable("T_Lender");
                DataTable t_car = new DataTable("T_Car");
                DataTable t_lendercar = new DataTable("T_LenderCar");

                //DataAdapter mit SELECT Befehl für Tabelle T_Carsharing
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT p_branchNo, name, adress FROM T_Carsharing", this.connection);
                //Befüllen der Tabelle
                dataAdapter.Fill(t_carsharing);
                //Ressourcenfreigabe
                dataAdapter.Dispose();

                //DataAdapter mit SELECT Befehl für Tabelle T_Lender
                dataAdapter = new SQLiteDataAdapter("SELECT p_lenderID, name, age, adress FROM T_Lender", this.connection);
                dataAdapter.Fill(t_lender);
                dataAdapter.Dispose();

                //DataAdapter mit SELECT Befehl für Tabelle T_Car
                dataAdapter = new SQLiteDataAdapter("SELECT p_licenseTag, model, manufacturer, pricePerDay, p_f_branchNo FROM T_Car", this.connection);
                dataAdapter.Fill(t_car);
                dataAdapter.Dispose();

                //DataAdapter mit SELECT Befehl für Tabelle T_LenderCar
                dataAdapter = new SQLiteDataAdapter("SELECT p_f_lenderId, p_f_licenseTag FROM T_LenderCar", this.connection);
                dataAdapter.Fill(t_lendercar);
                dataAdapter.Dispose();
                connection.Close();
                //Erstellen und Füllen des DataSet's
                DataSet carsharingData = new DataSet("CarsharingData");
                carsharingData.Tables.Add(t_carsharing);
                carsharingData.Tables.Add(t_lender);
                carsharingData.Tables.Add(t_car);
                carsharingData.Tables.Add(t_lendercar);

                /* Info Für Markus: 
                 *  Mit DataSet.tables["Tabellenname"] oder DataSet.tables[index] kann man
                 *  auf die entsprechende Tabelle zugreifen.
                 */

                return carsharingData;
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
        }

        //Auto Ausleihen
        public void InsertLending(int lenderId, string licenseTag) //Done but not tested
        {
            /* Tests und weitere Einschränkungen nötig:
             * 
             *      Wann darf ein Fahrzeug ausgeliehen werden?
             *      Dürfen mehrere Fahrzeuge gleichzeitig ausgeliehen werden?
             * 
             * Aktuell wird ohne wenn und aber der Datensatz eingefügt
             * 
             * Try Catch SQLiteException einbauen?
             */
            try
            {
                command = new SQLiteCommand(this.connection);
                command.CommandText = "INSERT INTO T_LenderCar (p_f_lenderId, p_f_licenseTag) VALUES('" + lenderId + "','" + licenseTag + "')";
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                //Freigabe der Ressourcen
                command.Dispose();
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
        }

        //Ausleihe Löschen
        public void RemoveLending(int lenderId, string licenseTag)  //DONE but not tested
        {
            /* Wann darf ein Mietverhältnis aufgehoben / gelöscht werden?
             *
             *
             */

            if (GetRentedCars(lenderId).Contains(licenseTag))
            {
                try
                {
                    command = new SQLiteCommand(this.connection);
                    command.CommandText = "DELETE FROM T_LenderCar WHERE p_f_lenderId = " + lenderId + " AND p_f_licenseTag = " + "'" + licenseTag + "'";
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    command.Dispose();
                }
                catch (SQLiteException exception)
                {
                    throw exception;
                }
            }
            else
            {

                throw new Exception("Auto konnte nicht zurueckgegeben werden");
            }
        }

        //Niederlassun hinzufügen
        public void CreateBranch(string name, string adress)
        {
            //TODO - Carsharing Niederlassung anlegen (Datensatz in die Datenbank schreiben
            try
            {
                command = new SQLiteCommand(this.connection);
                command.CommandText = "INSERT INTO T_Carsharing (name, adress) VALUES('" + name + "','" + adress + "');";
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
        }

        //Niederlassung entfernen
        public void RemoveBranch(int branchNo)
        {
            //TODO - Carsharing Niederlassung entfernen (Datensatz aus der Datenbank löschen)
            //Prüfen ob Fahrzeuge der Niederlassung zugewiesen sind
            try
            {
                command = new SQLiteCommand(this.connection);
                command.CommandText = "DELETE FROM T_Carsharing WHERE p_branchNo = " + branchNo + ");";
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
        }

        //Mieter anlegen   
        public void CreateLender(string name, int age, string adress)   //DONE
        {
            try
            {
                command = new SQLiteCommand(this.connection);
                // Einfügen eines Datensatzes
                command.CommandText = "INSERT INTO T_Lender (name, age, adress) VALUES('" + name + "','" + age + "','" + adress + "');";
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                // Freigabe der Ressourcen.
                command.Dispose();
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
        }

        //Mieter löschen
        public void RemoveLender(int lenderId) //DONE
        {

            List<string> licenseTags = GetRentedCars(lenderId);
            if (licenseTags.Count < 1)
            {
                try
                {
                    command = new SQLiteCommand(this.connection);
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    command.CommandText = "DELETE FROM T_Lender WHERE p_lenderId = " + lenderId.ToString() + ";";
                    command.ExecuteNonQuery();
                    connection.Close();
                    // Freigabe der Ressourcen.
                    command.Dispose();
                }
                catch (SQLiteException exception)
                {
                    throw exception;
                }
            }
            else
                throw new Exception("Der Benutzer hat noch Autos ausgeliehen und kann deswegen nicht gelöscht werden.");
        }

        //Mieter anzeigen
        public void ShowLender(int lenderID)
        {
            try
            {
                command = new SQLiteCommand(this.connection);
                command.CommandText = "SELECT * FROM T_Lender WHERE p_lenderId = " + lenderID + ";";
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
        }

        //Auto erstellen
        public void CreateCar(string licenseTag, string model, string manufacturer, decimal pricePerDay, int assignedBranchNo)
        {
            try
            {
                command = new SQLiteCommand(this.connection);
                command.CommandText = "INSERT INTO T_Car (p_licenseTag, model, manufacturer, priceperDay, p_f_branchNo) VALUES('" + licenseTag + "','" + model + "','" + manufacturer + "','" + pricePerDay + "','"+ assignedBranchNo + "');";
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
        }

        //Auto löschen 
        public void RemoveCar(string licenseTag)
        {
            try
            {
                //TODO: Artem 
                command = new SQLiteCommand(this.connection);
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command.CommandText = "DELETE FROM T_Car WHERE p_licenseTag = '" + licenseTag + "';";
                command.ExecuteNonQuery();
                connection.Close();
                // Freigabe der Ressourcen.
                command.Dispose();
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }

        }

        //Ausgeliehene Autos pro Mieter 
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
                //Freigabe der Ressourcen
                connection.Close();
                command.Dispose();
                reader.Dispose();

                //Rückgabe der Liste
                return licenseTagList;
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
        }
    }
}
