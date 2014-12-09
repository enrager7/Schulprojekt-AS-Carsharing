using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Carsharing
{
    class Lender
    {
        private int lenderId;
        private string name;
        private int age;
        private string adress;
        private List<string> lendedCars;

        public Lender(string name, int age, string adress)
        {
            this.name = name;
            this.age = age;
            this.adress = adress;
            lendedCars = new List<string>();
        }

        public Lender()
        {
        } 

        public Lender(int lenderId, string name, int age, string adress)
        {
            this.lenderId = lenderId;
            this.name = name;
            this.age = age;
            this.adress = adress;
            lendedCars = new List<string>();
        }

        public void InsertLendedCars(List<string> rentedCarsList) 
        {
            this.lendedCars = rentedCarsList;
        }

        public void SetLenderId(int lenderId)
        {
            this.lenderId = lenderId;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void SetAdress(string adress)
        {
            this.adress = adress;
        }

        public int GetLenderId() 
        {
            return this.lenderId;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetAge()
        {
            return this.age;
        }

        public string GetAdress()
        {
            return this.adress;
        }
    }
}
