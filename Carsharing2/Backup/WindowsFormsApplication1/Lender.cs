using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing
{
    class Lender
    {
        private int lenderId;
        private string name;
        private int age;
        private string adress;

        public Lender(string name, int age, string adress)
        {
            this.name = name;
            this.age = age;
            this.adress = adress;
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
        }

        public void setLenderId(int lenderId)
        {
            this.lenderId = lenderId;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setage(int age)
        {
            this.age = age;
        }


        public void setAdress(string adress)
        {
            this.adress = adress;
        }


        public int getLenderId() 
        {
            return this.lenderId;
        }
        public string getName()
        {
            return this.name;
        }

        public int getAge()
        {
            return this.age;
        }

        public string getAdress()
        {
            return this.adress;
        }


        public bool isRemovable(Lender lender, List<string> licenseTagList)
        {
            //licenseTagList.Find(Convert.ToString(lender.getLenderId()));

            //if (licenseTagList.Find(lender.getLenderId()))
            //{
                return true;  
            //}
            //return false;
        }
    }
}
