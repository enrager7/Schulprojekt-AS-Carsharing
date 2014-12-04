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
        //Private attributes
        private IDatabase persistence;
        private DataSet carsharingData;
        private List<Branch> branchlist;
        private List<Car> carlist;
        private List<Lender> lenderlist;

        /* Wollen wir für die Listen public Properties mit einem setter
         * anlegen, dan brauchen wir bei Aktualisierung der data nicht ständig das DataSet bzw. die Listen an die 
         * Form1 bzw. die TUI zu übergeben.
         * Dann kann mann nämlich in der Form1.cs über carsharinginstance.Branchlist etc. auf die drinliegenden Objekte zugreifen.
         *                  
         * Siehe Properties ab Zeile 29
         */
        private bool dataChanged;

        //Public properties
        public bool DataChanged { get { return this.dataChanged; } set { if (value == true) { LoadData(); ReloadInstances(); value = true; } else value = false; } }//Reload Data after any changes to database (macht das Sinn?)
        public List<Branch> BranchList { get { return this.branchlist; } } //Nur Lesezugriff
        public List<Car> CarList { get { return this.carlist; } }
        public List<Lender> LenderList { get { return this.lenderlist; } }
        public CarsharingSystem(string savetype)
        {
            //Instanziere der benötigten Listen
            this.dataChanged = false;
            this.branchlist = new List<Branch>();
            this.carlist = new List<Car>();
            this.lenderlist = new List<Lender>();
            //Instanziere Datenbankanbindung
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
            //Instanzierung der Klassen in Objekte
            CreateInstances();
        }
        /*  Makus,du kannst dich entscheiden ob du lieber mit den Listen und Objekten,
         * oder mit dem DataSet arbeiten möchtest.
         * */
        #region dataLoadingStuff
        private void CreateInstances()
        {
            //Daten aus der Datenbank lesen
            DataSet carsharingData = this.GetDataSet();

            //Instanzierung Branches
            foreach (DataRow dr in carsharingData.Tables["T_Carsharing"].Rows)
            {
                //Für jeden Eintrag in der Carsharing Tabelle(Niederlassungen)
                Branch tempBranch = new Branch(Convert.ToInt32(dr.ItemArray.GetValue(0)), Convert.ToString(dr.ItemArray.GetValue(1)), Convert.ToString(dr.ItemArray.GetValue(2)));
                this.branchlist.Add(tempBranch);
            }

            //Instanzierung Lender
            foreach (DataRow dr in carsharingData.Tables["T_Lender"].Rows)
            {
                //Für jeden Eintrag in der Lender Tabelle
                Lender tempLender = new Lender(Convert.ToInt32(dr.ItemArray.GetValue(0)), Convert.ToString(dr.ItemArray.GetValue(1)), Convert.ToInt32(dr.ItemArray.GetValue(2)), Convert.ToString(dr.ItemArray.GetValue(3)));
                tempLender.InsertLendedCars(this.persistence.GetRentedCars(tempLender.GetLenderId()));
                this.lenderlist.Add(tempLender);
            }
            //Instanzierung Cars
            foreach (DataRow dr in carsharingData.Tables["T_Car"].Rows)
            {
                Car tempCar = new Car(Convert.ToString(dr.ItemArray.GetValue(0)), Convert.ToString(dr.ItemArray.GetValue(1)), Convert.ToString(dr.ItemArray.GetValue(2)), Convert.ToDecimal(dr.ItemArray.GetValue(3)), Convert.ToInt32(dr.ItemArray.GetValue(4)));
                this.carlist.Add(tempCar);
            }
        }
        //Erneuern der Instanzdaten
        private void ReloadInstances()
        {
            this.branchlist.Clear();
            this.lenderlist.Clear();
            this.carlist.Clear();
            CreateInstances();
            DataChanged = false;
        }
        public void LoadData()//Laden der Daten aus der Datenbank in das DataSet "carsharingData"
        {
            this.carsharingData = this.persistence.LoadData();
        }

        public void DataListTransfer()
        {
            //TODO: Methode soll sämtliche Listen(carlist, lenderlist, branchlist) an die Form bzw. die TUI übergeben. Eine Idee wie? 3 Listen in eine neue Liste Packen? Oder in eine Dictionary? Im Array?
            //Oder Zugriff über Public Property mit getter. Siehe kommentar oben bei zeile 19.
        }

        //Lädt Daten aus der Datenbank in das DataSet "carsharingData" und gibt es anschließend zurück. Kann zum Aktualisieren des DataSets verwendet werden.
        public DataSet GetDataSet()
        {
            LoadData();
            return this.carsharingData;
        }
        #endregion

        #region carsharingCommands
        //Niederlassung erstellen
        public void CreateBranch(string name, string adress)
        {
            this.persistence.CreateBranch(name, adress);
            DataChanged = true;
        }
        //Niederlassung entfernen
        public void RemoveBranch(int branchNo)
        {
            this.persistence.RemoveBranch(branchNo);
            DataChanged = true;
        }

        //Ausleihen
        public void LentCar(int lenderID, string licenseTag)
        {
            this.persistence.InsertLending(lenderID, licenseTag);
            DataChanged = true;
        }

        //Löschen
        public void ReturnCar(int lenderID, string licenseTag)
        {
            this.persistence.RemoveLending(lenderID,licenseTag);
            DataChanged = true;
        }

        //Mieter anlegen
        public void CreateLender(string name, int age, string adress)
        {
            this.persistence.CreateLender(name, age, adress);
            DataChanged = true;
        }

        //Mieter anzeigen
        public void ShowLender(int lenderId)
        {
            this.persistence.ShowLender(lenderId);
        }

        //Mieter löschen
        public void RemoveLender(int lenderId)
        {
            Lender lender = new Lender();
            this.persistence.RemoveLender(lenderId);
            DataChanged = true;
        }

        //Auto anlegen
        public void CreateCar(string licenseTag, string model, string manufacturer, decimal pricePerDay, int assignedBranchNo)
        {
            this.persistence.CreateCar(licenseTag, model, manufacturer, pricePerDay, assignedBranchNo);
            DataChanged = true;
        }

        //Auto löschen
        public void RemoveCar(string licenseTag)
        {
            this.persistence.RemoveCar(licenseTag);
            DataChanged = true;
        }
        #endregion
    }
}
