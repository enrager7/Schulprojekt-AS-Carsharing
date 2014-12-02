using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing
{
    class Carsharing
    {
        private int branchNo;
        private string name;
        private string adress;
        private IDatabase persistence;

        public Carsharing(int branchNo, string name, string adress)
        {
            this.branchNo = branchNo;
            this.name = name;
            this.adress = adress;
            this.persistence = new Database("Carsharing.db");
        }

        public void loadData()
        {
            this.persistence.loadData();
        }

        public void setBranchNo(int branchNo)
        {
            this.branchNo  = branchNo;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setAdress(string adress)
        {
            this.adress = adress;
        }


        public int getBranchNo() 
        {
            return this.branchNo;
        }
        public string getName()
        {
            return this.name;
        }
        public string getAdress()
        {
            return this.adress;
        }

        //Ausleihen
        public void lentCar(Lender lender, Car car)
        {
            this.persistence.insertLending(lender.getLenderId(), car.getLicenseTag());
        }
        //Löschen
        public void returnCar(Lender lender, Car car)
        {
            
            this.persistence.removeLending(lender.getLenderId(), car.getLicenseTag());
        }
        //Mieter anlegen
        public void createLender(string name, int age, string adress)
        {
            this.persistence.createLender(name, age, adress);
        }
        //Mieter anzeigen
        public void showLender(int lenderId)
        {
            this.persistence.showLender(lenderId);
        }

        //Mieter löschen
        public void removeLender(int lenderID)
        {
            Lender lender = new Lender();
            this.persistence.removeLender(lender);
        }
        //Auto anlegen
        public void createCar(string licenseTag, string model, string manufacturer, decimal pricePerDay)
        {
            this.persistence.createCar(licenseTag, model, manufacturer, pricePerDay);
        }

        //Auto löschen
        public void deleteCar(string licenseTag)
        {
            this.persistence.deleteCar(licenseTag);
        }
    }
}
