using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing
{
    interface IDatabase
    {
        void insertLending(int lenderId, string licenseTag);

        void removeLending(int lenderId, string licenseTag);

        void createLender(string name, int age, string adress);

        void removeLender(Lender lender);

        void showLender(int lenderID);

        void createCar(string licenseTag, string model, string manufacturer, decimal pricePerDay);

        void deleteCar(string licenseTag);

        void loadData();

        List<string> getRentedCars(int lenderID);
    }
}
