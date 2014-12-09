using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace Carsharing
{
    [Serializable]
    class SerializedDatabase : IDatabase
    {
        private DataSet carsharingData;
        private DataTable t_carsharing;
        private DataTable t_lender;
        private DataTable t_car;
        private DataTable t_lendercar;
        public DataSet CarsharingData { get { return this.carsharingData; } set { this.carsharingData = value; } }

        public SerializedDatabase()
        {
            if (File.Exists("data.dat"))
                this.carsharingData = (DataSet)Serializer.LoadObject("data.dat"); //Laden der Binärdaten
            else
            {
                this.carsharingData = new DataSet("CarsharingData");
                // Erstelle Tabelle T_Carsharing
                this.t_carsharing = new DataTable("T_Carsharing");
                this.t_carsharing.Columns.Add(new DataColumn("p_branchNo", dataType: typeof(System.Int32)));
                this.t_carsharing.Columns.Add(new DataColumn("name", dataType: typeof(System.String)));
                this.t_carsharing.Columns.Add(new DataColumn("adress", dataType: typeof(System.String)));
                this.t_carsharing.PrimaryKey = new DataColumn[] { t_carsharing.Columns["p_branchNo"] };
                this.t_carsharing.Columns["p_branchNo"].AutoIncrement = true;
                this.t_carsharing.Columns["p_branchNo"].AutoIncrementSeed = 1;
                this.t_carsharing.Columns["p_branchNo"].AutoIncrementStep = 1;
                this.carsharingData.Tables.Add(this.t_carsharing);

                // Erstelle Tabelle T_Lender
                this.t_lender = new DataTable("T_Lender");
                this.t_lender.Columns.Add(new DataColumn("p_lenderId", dataType: typeof(System.Int32)));
                this.t_lender.PrimaryKey = new DataColumn[] { t_lender.Columns["p_lenderId"] };
                this.t_lender.Columns.Add(new DataColumn("name", dataType: typeof(System.String)));
                this.t_lender.Columns.Add(new DataColumn("age", dataType: typeof(System.Int32)));
                this.t_lender.Columns.Add(new DataColumn("adress", dataType: typeof(System.String)));
                this.t_lender.PrimaryKey = new DataColumn[] { t_lender.Columns["p_lenderId"] };
                this.t_lender.Columns["p_lenderId"].AutoIncrement = true;
                this.t_lender.Columns["p_lenderId"].AutoIncrementSeed = 1;
                this.t_lender.Columns["p_lenderId"].AutoIncrementStep = 1;
                this.carsharingData.Tables.Add(this.t_lender);

                // Erstelle Tabelle T_Car
                this.t_car = new DataTable("T_Car");
                this.t_car.Columns.Add(new DataColumn("p_licenseTag", dataType: typeof(System.String)));
                this.t_car.Columns.Add(new DataColumn("model", dataType: typeof(System.String)));
                this.t_car.Columns.Add(new DataColumn("manufacturer", dataType: typeof(System.String)));
                this.t_car.Columns.Add(new DataColumn("priceperDay", dataType: typeof(System.Decimal)));
                this.t_car.Columns.Add(new DataColumn("p_f_branchNo", dataType: typeof(System.Int32)));
                this.t_car.PrimaryKey = new DataColumn[] { t_car.Columns["p_licenseTag"] };
                this.carsharingData.Tables.Add(this.t_car);

                // Erstelle Tabelle T_LenderCar
                this.t_lendercar = new DataTable("T_LenderCar");
                this.t_lendercar.Columns.Add(new DataColumn("p_f_lenderId", dataType: typeof(System.Int32)));
                this.t_lendercar.Columns.Add(new DataColumn("p_f_licenseTag", dataType: typeof(System.String)));
                this.t_lendercar.PrimaryKey = new DataColumn[] { t_lendercar.Columns["p_f_lenderId"], t_lendercar.Columns["p_f_licenseTag"] };
                this.carsharingData.Tables.Add(this.t_lendercar);

                //Foreign Key Constraints
                ForeignKeyConstraint carlicensetagTLenderCar = new ForeignKeyConstraint(this.CarsharingData.Tables["T_LenderCar"].Columns["p_f_licenseTag"], this.CarsharingData.Tables["T_Car"].Columns["p_licenseTag"]);
                carlicensetagTLenderCar.DeleteRule = Rule.None;
                carlicensetagTLenderCar.UpdateRule = Rule.Cascade;

                this.CarsharingData.Tables["T_LenderCar"].Constraints.Add(carlicensetagTLenderCar);
                this.CarsharingData.EnforceConstraints = true;

                //testdaten
                //Branches erstellen
                if (this.CarsharingData.Tables["T_Carsharing"].Rows.Count < 3)
                {
                    this.CreateBranch("Fahrzeug Depot", "Unter den Linden 14");
                    this.CreateBranch("Autoverleih Berlin Mitte", "Alexanderstraße 32");
                    this.CreateBranch("Autoverleih Flughafen Schönefeld", "Unter dem Flughafen 1");
                }
                if (this.CarsharingData.Tables["T_Lender"].Rows.Count < 3)
                {
                    this.CreateLender("Artem Efimov", 26, "Berliner Alee 78");
                    this.CreateLender("Markus Hoefgen", 25, "Haarlemer Straße 3, OSZimt");
                    this.CreateLender("Pierre Jenchen", 35, "Im Palast, Königssuite");
                    this.CreateLender("Hansee der Penner", 55, "obdachlos");
                }
                if (this.CarsharingData.Tables["T_Car"].Rows.Count < 3)
                {
                    this.CreateCar("B-MW-586", "BMW", "M3", (decimal)14.95, 2);
                    this.CreateCar("B-FE-542", "Ferrari", "La Ferrari", (decimal)14.95, 2);
                    this.CreateCar("B-AU-193", "Audi", "M3", (decimal)14.95, 2);
                }

            }
        }
        // Destruktor wird benötig um beim Schließen des Programms sämltichen relevanten zu speichern
        ~SerializedDatabase()
        {
            if (this.carsharingData != null)
                Serializer.SaveObject(carsharingData, "data.dat");
        }

        public DataSet LoadData()
        {
            return this.carsharingData;
        }


        public void InsertLending(int lenderId, string licenseTag)
        {
            try 
            {
                if (this.CarsharingData.Tables["T_LenderCar"].Rows.Contains(new object[] { lenderId, licenseTag }))
                {
                    //Bereits eine Kombination von der lenderId und licenseTag
                }
                else
                {
                    bool foundCar = false;
                    foreach (DataRow dr in this.CarsharingData.Tables["T_LenderCar"].Rows)
                    {
                        if (Convert.ToString(dr.ItemArray.GetValue(1)) == licenseTag)
                            foundCar = true;
                    }
                    if(foundCar != true)
                        this.CarsharingData.Tables["T_LenderCar"].Rows.Add(lenderId, licenseTag);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveLending(int lenderId, string licenseTag)
        {
            try
            {
                if (this.CarsharingData.Tables["T_LenderCar"].Rows.Contains(new object[] { lenderId, licenseTag }))//Find(lenderId, licenseTag)
                {
                this.CarsharingData.Tables["T_LenderCar"].Rows.Find(new object[] { lenderId, licenseTag }).Delete();
                }
            }
            catch
            {
                throw new Exception("Die Ausleihe konnte nicht entfernt werden.");
            }
        }

        // Ausleiher anlegen
        public void CreateLender(string name, int age, string adress)
        {
            try
            {   // Legt den Datensatz an
                this.CarsharingData.Tables["T_Lender"].Rows.Add(null, name, age, adress);
            }
            catch
            {
                throw new Exception("Fehler beim Erstellen eines Lenders. Methode " + "'" + "CreateLender" + "'" + "überprüfen!");
            }
        }

        // Lender entfernen
        public void RemoveLender(int lenderId)
        {
            try
            {   //Entfernt die Reihe mit id = lenderId aus der T_Lender Tabelle
                this.CarsharingData.Tables["T_Lender"].Rows.Find(lenderId).Delete();
            }
            catch
            {
                throw new Exception("Fehler beim Löschen des Ausleihers mit ID: " + "'" + lenderId + "'");
            }
        }

        public void ShowLender(int lenderID)
        {
            throw new NotImplementedException();
        }
        // Fahrzeug entfernen
        public void CreateCar(string licenseTag, string model, string manufacturer, decimal pricePerDay, int assignedBranchNo)
        {
            try
            {   //Füge Datensatz ein
                this.CarsharingData.Tables["T_Car"].Rows.Add(licenseTag, model, manufacturer, pricePerDay, assignedBranchNo);
            }
            catch
            {
                throw new Exception("Fahrzeug konnte nicht angelegt werden.");
            }
        }

        // Fahrzeug anlegen
        public void RemoveCar(string licenseTag)
        {
            try
            {
                this.CarsharingData.Tables["T_Car"].Rows.Find(licenseTag).Delete();
            }
            catch
            {
                throw new Exception("Fahrzeug konnte nicht entfernt werden.");
            }
        }

        public List<string> GetRentedCars(int lenderID)
        {
            List<string> licenseTagList = new List<string>();
            foreach (DataRow dr in this.carsharingData.Tables["T_LenderCar"].Rows)
            {
                if (Convert.ToInt32(dr.ItemArray.GetValue(0)) == lenderID)
                {
                    licenseTagList.Add(dr.ItemArray[1].ToString());
                }
            }
            return licenseTagList;
        }

        public List<string> GetAllRentedCars() 
        {
            List<string> licenseTagList = new List<string>();
            foreach (DataRow dr in this.carsharingData.Tables["T_LenderCar"].Rows)
            {
                    licenseTagList.Add(dr.ItemArray[1].ToString());
            }
            return licenseTagList; 
        }
        
        // Niederlassung anlegen
        public void CreateBranch(string name, string adress)
        {
            try
            {   // Legt den Datensatz an
                this.CarsharingData.Tables["T_Carsharing"].Rows.Add(null, name, adress);
            }
            catch
            {
                throw new Exception("Niederlassung konnte nicht angelegt werden.");
            }
        }

        // Niederlassung entfernen
        public void RemoveBranch(int branchNo)
        {
            try
            {   //Entfernt den Datensatz
                this.CarsharingData.Tables["T_Carsharing"].Rows.Find(branchNo).Delete();
            }
            catch
            {
                throw new Exception("Niederlassung konnte nicht entfernt werden.");
            }
        }
    }
}
