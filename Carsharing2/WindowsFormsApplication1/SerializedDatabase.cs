using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace Carsharing
{   [Serializable]
    class SerializedDatabase : IDatabase
    {
        private DataSet carsharingData;
        private DataTable t_carsharing;
        private DataTable t_lender;
        private DataTable t_car;
        private DataTable t_lendercar;
        public DataSet CarsharingData {get {return this.carsharingData; } set {this.carsharingData = value;} }

        public SerializedDatabase() //Werden Übergabeparameter benötigt?
        {
            if(File.Exists("data.dat"))
                this.carsharingData = (DataSet)Serializer.LoadObject("data.dat");
            else
            {
            this.carsharingData = new DataSet("CarsharingData");
            // Erstelle Tabelle T_Carsharing
            this.t_carsharing = new DataTable("T_Carsharing");
            this.t_carsharing.Columns.Add(new DataColumn("p_branchNo", dataType: typeof(System.Int32)));
            this.t_carsharing.Columns.Add(new DataColumn("name", dataType: typeof(System.String)));
            this.t_carsharing.Columns.Add(new DataColumn("adress", dataType: typeof(System.String)));
            this.t_carsharing.PrimaryKey = new DataColumn[] { t_carsharing.Columns["p_branchNo"] };
            this.carsharingData.Tables.Add(this.t_carsharing);

            // Erstelle Tabelle T_Lender
            this.t_lender = new DataTable("T_Lender");
            this.t_lender.Columns.Add(new DataColumn("p_lenderId", dataType:typeof(System.Int32)));
            this.t_lender.PrimaryKey = new DataColumn[] { t_lender.Columns["p_lenderId"] };
            this.t_lender.Columns.Add(new DataColumn("name", dataType:typeof(System.String)));
            this.t_lender.Columns.Add(new DataColumn("age", dataType:typeof(System.Int32)));
            this.t_lender.Columns.Add(new DataColumn("adress", dataType:typeof(System.String)));
            this.t_lender.PrimaryKey = new DataColumn[] { t_lender.Columns["p_lenderId"] };
            this.t_lender.Columns["p_lenderId"].AutoIncrement = true;
            this.t_lender.Columns["p_lenderId"].AutoIncrementStep = 1;
            this.carsharingData.Tables.Add(this.t_lender);
            
            // Erstelle Tabelle T_Car
            this.t_car = new DataTable("T_Car");
            this.t_car.Columns.Add(new DataColumn("p_licenseTag", dataType: typeof(System.String)));
            this.t_car.Columns.Add(new DataColumn("model", dataType:typeof(System.String)));
            this.t_car.Columns.Add(new DataColumn("manufacturer", dataType:typeof(System.String)));
            this.t_car.Columns.Add(new DataColumn("priceperDay", dataType:typeof(System.Decimal)));
            this.t_car.Columns.Add(new DataColumn("p_f_branchNo", dataType:typeof(System.Int32)));
            this.t_car.PrimaryKey = new DataColumn[] { t_car.Columns["p_licenseTag"] };
            this.carsharingData.Tables.Add(this.t_car);
            
            // Erstelle Tabelle T_LenderCar
            this.t_lendercar = new DataTable("T_LenderCar");
            this.t_lendercar.Columns.Add(new DataColumn("p_f_lenderId", dataType: typeof(System.Int32)));
            this.t_lendercar.Columns.Add(new DataColumn("p_f_licenseTag", dataType: typeof(System.String)));
            this.carsharingData.Tables.Add(this.t_lendercar);
            
            }
        }
        //Destruktor
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
            throw new NotImplementedException();
        }

        public void RemoveLending(int lenderId, string licenseTag)
        {
            throw new NotImplementedException();
        }

        public void CreateLender(string name, int age, string adress)
        {
            try
            {
                this.CarsharingData.Tables["T_Lender"].Rows.Add(null, name, age, adress);
            }
            catch 
            {
                throw new Exception("Fehler beim Erstellen eines Lenders. Methode "+"'" + "CreateLender" + "'" + "überprüfen!");
            }
        }

        public int getlastLenderId()
        {
            int i = 0;
            foreach(DataRow dr in carsharingData.Tables["T_Lender"].Rows)
            {
                if(Convert.ToInt32(dr.ItemArray[0]) > i)
                    i++;
            }
            return i+1;
        }
        public void RemoveLender(int lenderId)
        {
            //DataRow temp = new DataRow();
            /*foreach (DataRow dr in this.CarsharingData.Tables["T_Lender"].Rows)
            {
                if(Convert.ToInt32(dr.ItemArray.GetValue(0)) == lenderId)
                {
                    temp = dr;
                }
            }*/
            this.CarsharingData.Tables["T_Lender"].Rows.Find(lenderId).Delete();

        }

        public void ShowLender(int lenderID)
        {
            throw new NotImplementedException();
        }

        public void CreateCar(string licenseTag, string model, string manufacturer, decimal pricePerDay, int assignedBranchNo)
        {
            throw new NotImplementedException();
        }

        public void RemoveCar(string licenseTag)
        {
            throw new NotImplementedException();
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

        public void CreateBranch(string name, string adress)
        {
            throw new NotImplementedException();
        }

        public void RemoveBranch(int branchNo)
        {
            throw new NotImplementedException();
        }
    }
}
