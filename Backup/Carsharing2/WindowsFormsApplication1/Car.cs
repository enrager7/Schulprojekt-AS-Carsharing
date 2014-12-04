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
        private int assignedBranchNo;


        public Car(string licenseTag, string model, string manufacturer, decimal pricePerDay, int assignedBranchNo)
        {
            this.licenseTag = licenseTag;
            this.model = model;
            this.manufacturer = manufacturer;
            this.pricePerDay = pricePerDay;
            this.assignedBranchNo = assignedBranchNo;
        }

        public void SetLicenseTag(string licenseTag)
        {
            this.licenseTag = licenseTag;
        }

        public void SetModel(string model)
        {
            this.model = model;
        }

        public void SetManufacturer(string manufacturer)
        {
            this.manufacturer = manufacturer;
        }

        public void SetPricePerDay(decimal pricePerDay)
        {
            this.pricePerDay = pricePerDay;
        }

        public string GetLicenseTag() 
        {
            return this.licenseTag;
        }

        public string GetModel()
        {
            return this.model;
        }

        public string GetManufacturer()
        {
            return this.manufacturer;
        }

        public decimal GetPricePerDay()
        {
            return this.pricePerDay;
        }
    }
}
