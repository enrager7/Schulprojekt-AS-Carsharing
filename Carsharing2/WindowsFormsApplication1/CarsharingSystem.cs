using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Carsharing
{
    class CarsharingSystem
    {
        // Private Attribute
        private IDatabase persistence;
        private DataSet carsharingData;

        public CarsharingSystem(string savetype)
        {
            // Instanziere Datenbankanbindung
            if (savetype == "sqlite")
                this.persistence = new Database("Carsharing.db");
            else 
            {
                if (savetype == "serializer")
                {
                    this.persistence = new SerializedDatabase();
                }
                else
                {
                    throw new Exception("Savetype nicht festgelegt!");
                }
            }
        }
        #region dataLoadingStuff
        
        // Laden der Daten aus der Datenbank in das DataSet "carsharingData"
        public void LoadData()
        {
            this.carsharingData = this.persistence.LoadData();
        }

        public List<string> GetRentedCarsFromDataBase()
        {
            return this.persistence.GetAllRentedCars();
        }

        // Lädt Daten aus der Datenbank in das DataSet "carsharingData" und gibt es anschließend zurück. Kann zum Aktualisieren des DataSets verwendet werden.
        public DataSet GetDataSet()
        {
            LoadData();
            return this.carsharingData;
        }
        #endregion

        #region carsharingCommands
        // Niederlassung erstellen
        public void CreateBranch(string name, string adress)
        {
            this.persistence.CreateBranch(name, adress);
        }
        // Niederlassung entfernen
        public void RemoveBranch(int branchNo)
        {
            this.persistence.RemoveBranch(branchNo);
        }
        // Fahrzeug ausleihen
        public void LentCar(int lenderID, string licenseTag)
        {
            this.persistence.InsertLending(lenderID, licenseTag);
        }

        // Löschen
        public void ReturnCar(int lenderID, string licenseTag)
        {
            this.persistence.RemoveLending(lenderID,licenseTag);
        }

        // Mieter anlegen
        public void CreateLender(string name, int age, string adress)
        {
            this.persistence.CreateLender(name, age, adress);
        }

        // Mieter anzeigen
        public void ShowLender(int lenderId)
        {
            this.persistence.ShowLender(lenderId);
        }

        // Mieter löschen
        public void RemoveLender(int lenderId)
        {
            this.persistence.RemoveLender(lenderId);
        }

        // Auto anlegen
        public void CreateCar(string licenseTag, string model, string manufacturer, decimal pricePerDay, int assignedBranchNo)
        {
            this.persistence.CreateCar(licenseTag, model, manufacturer, pricePerDay, assignedBranchNo);
        }

        // Auto löschen
        public void RemoveCar(string licenseTag)
        {
            this.persistence.RemoveCar(licenseTag);
        }
        #endregion
    }
}
