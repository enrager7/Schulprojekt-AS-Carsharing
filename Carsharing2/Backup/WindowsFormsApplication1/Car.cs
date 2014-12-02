using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing
{
    class Car
    {
        private string licenseTag;
        private string model;
        private string manufacturer;
        private decimal pricePerDay;


        public Car(string licenseTag, string model, string manufacturer, decimal pricePerDay)
        {
            this.licenseTag = licenseTag;
            this.model = model;
            this.manufacturer = manufacturer;
            this.pricePerDay = pricePerDay;
        }

        public void setLicenseTag(string licenseTag)
        {
            this.licenseTag = licenseTag;
        }

        public void setModel(string model)
        {
            this.model = model;
        }

        public void setManufacturer(string manufacturer)
        {
            this.manufacturer = manufacturer;
        }


        public void setPricePerDay(decimal pricePerDay)
        {
            this.pricePerDay = pricePerDay;
        }


        public string getLicenseTag() 
        {
            return this.licenseTag;
        }
        public string getModel()
        {
            return this.model;
        }

        public string getManufacturer()
        {
            return this.manufacturer;
        }

        public decimal getPricePerDay()
        {
            return this.pricePerDay;
        }
    }
}
