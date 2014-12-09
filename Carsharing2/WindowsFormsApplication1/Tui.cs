using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Carsharing
{
    class Tui : IUi
    {
        private CarsharingSystem carsharinginstance;//Deklaration
        private DataSet dataImage;
        private List<Lender> lenderList = new List<Lender>();
        private List<Car> carList = new List<Car>();
        private ArrayList LenderCarList = new ArrayList();

        public void show(string savetype)
        {
            carsharinginstance = new CarsharingSystem(savetype);
            initLists();
            string returnvalue;
            int lenderId;
            string licenseTag;

            CarsharingSystem carsharingsystem = new CarsharingSystem(savetype);
            do 
            {
                initLists();
                returnvalue = showmenu();
                switch (returnvalue)
                {
                    case "a":
                        Console.Clear();
                        Console.Write("Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Alter: ");
                        int age = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Adresse: ");
                        string adress = Console.ReadLine();

                        carsharingsystem.CreateLender(name, age, adress);
                        Console.WriteLine("Mieter angelegt.");
                        showLender();
                        break;

                    case "b":
                        showLender();
                        break;

                    case "c":
                        showLender();
                        Console.WriteLine();
                        Console.Write("Mieter ID zum löschen: ");
                        carsharingsystem.RemoveLender(Convert.ToInt32(Console.ReadLine()));
                        showLender();
                        Console.WriteLine("Mieter wurde gelöscht");
                        break;

                    case "d":
                        Console.Clear();
                        Console.Write("Kennzeichen: ");
                        licenseTag = Console.ReadLine();

                        Console.Write("Model: ");
                        string model = Console.ReadLine();

                        Console.Write("Hersteller: ");
                        string manufacturer = Console.ReadLine();

                        Console.Write("Preis pro Tag: ");
                        decimal pricePerDay = Convert.ToDecimal(Console.ReadLine());

                        carsharingsystem.CreateCar(licenseTag, model, manufacturer, pricePerDay, 1);
                        Console.WriteLine("Auto angelegt.");
                        showCar();
                        break;

                    case "e":
                        showCar();
                        break;

                    case "f":
                        showCar();
                        Console.WriteLine();
                        Console.Write("Autokennzeichen zum löschen: ");
                        carsharingsystem.RemoveCar(Console.ReadLine());
                        showCar();
                        Console.WriteLine("Auto wurde gelöscht");
                        break;

                    case "g":
                        showLenderCar();
                        Console.WriteLine("==================================");
                        Console.WriteLine("Auto asuleihen");
                        Console.WriteLine("==================================");
                        Console.Write("Mieter ID: ");
                        lenderId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Kennzeichen: ");
                        licenseTag = Console.ReadLine();
                        carsharingsystem.LentCar(lenderId, licenseTag);
                        Console.WriteLine("Auto wurde ausgeliehen.");
                        showLenderCar();
                        break;
                    case "h":
                        showLenderCar();
                        break;

                    case "i":
                        showLenderCar();
                        Console.WriteLine("==================================");
                        Console.WriteLine("Auto zurückgeben");
                        Console.WriteLine("==================================");
                        Console.Write("Mieter ID: ");
                        lenderId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Kennzeichen: ");
                        licenseTag = Console.ReadLine();

                        carsharingsystem.ReturnCar(lenderId, licenseTag);
                        Console.WriteLine("Auto wurde zurückgegeben");
                        showLenderCar();
                        break;
                }

                //Console.WriteLine("Esc drücken zum Beenden.");
                //Console.ReadLine();
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            
            
        }
        public string showmenu()
        {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("Autovermietung");
            Console.WriteLine("*************************************");
            Console.WriteLine("");
            Console.WriteLine("Mieter anlegen  (a)");
            Console.WriteLine("Mieter anzeigen (b)");
            Console.WriteLine("Mieter löschen  (c)");
            Console.WriteLine("");
            Console.WriteLine("*************************************");
            Console.WriteLine("");
            Console.WriteLine("Auto anlegen    (d)");
            Console.WriteLine("Auto anzeigen   (e)");
            Console.WriteLine("Auto löschen    (f)");
            Console.WriteLine("");
            Console.WriteLine("*************************************");
            Console.WriteLine("");
            Console.WriteLine("Auto Ausleihen  (g)");
            Console.WriteLine("Ausgeliehene Anzeigen (h)");
            Console.WriteLine("Auto zurückgeben(i)");
            return (Console.ReadLine());
        }
        public void showLender()
        {
            initLists();
            Console.Clear();
            string space;
            Console.WriteLine("ID     " + "Name                " + "Alter     " + "Adresse");
            Console.WriteLine("========================================================================");
            foreach (Lender lend in lenderList)
            {
                space = "      ";
                string agespace = "";
                if (lend.GetLenderId() > 9)
                {
                    space = "     ";
                }
                for (int i = 0; i <= 19 - Convert.ToInt32(lend.GetName().Length); i++)
                {
                    agespace += " ";
                }
                Console.WriteLine(lend.GetLenderId() + space + lend.GetName() + agespace + lend.GetAge() + "        " + lend.GetAdress());
            }
        }

        public void showCar()
        {
            initLists();
            Console.Clear();
            Console.WriteLine("Kennzeichen     " + "Hersteller           " + "Model                    " + "Preis pro Tag");
            Console.WriteLine("================================================================================");
            foreach (Car car in carList)
            {
                Console.WriteLine(car.GetLicenseTag() + getspace(car.GetLicenseTag(), 15) + car.GetManufacturer() + getspace(car.GetManufacturer(), 20) + car.GetModel() + getspace(car.GetModel(), 24) + car.GetPricePerDay());
            }
        }

        public void showLenderCar()
        {
            initLists();
            Console.Clear();
            Console.WriteLine("Mieter ID          Kennzeichen");
            Console.WriteLine("==============================");
            foreach (string[] lenderCar in LenderCarList)
            {
                Console.WriteLine("    "+lenderCar[0]+"              "+lenderCar[1]);
            }
        }

        public void initLists()
        {
            lenderList.Clear();
            carList.Clear();
            LenderCarList.Clear();

            dataImage = this.carsharinginstance.GetDataSet();
            DataTable lenderTable = dataImage.Tables["T_Lender"];
            foreach (DataRow row in lenderTable.Rows)
            {
                int id = Convert.ToInt32(row[0]);
                string name = row[1].ToString();
                int age = Convert.ToInt32(row[2]);
                string adress = row[3].ToString();

                Lender lender = new Lender(id, name, age, adress);

                lenderList.Add(lender);
            }

            DataTable carTable = dataImage.Tables["T_Car"];
            foreach (DataRow row in carTable.Rows)
            {
                string lictag = row[0].ToString();
                string model = row[1].ToString();
                string manufacturer = row[2].ToString();
                decimal pricePerDay = Convert.ToDecimal(row[3]);

                Car car = new Car(lictag, model, manufacturer, pricePerDay,1);

                carList.Add(car);
            }

            DataTable lenderCarTable = dataImage.Tables["T_LenderCar"];
            foreach (DataRow row in lenderCarTable.Rows)
            {
                string[] lenderCar = new String[2];
                lenderCar[0] = row[0].ToString();
                lenderCar[1] = row[1].ToString();

                LenderCarList.Add(lenderCar);
            }

        }

        public string getspace(string value, int headLenght)
        {
            string space = "";
            for (int i = 0; i <= headLenght - value.Length; i++)
            {
                space += " ";
            }
            return (space);
        }
    }
}
