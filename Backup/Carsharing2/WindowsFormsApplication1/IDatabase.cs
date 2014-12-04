using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Carsharing
{
    interface IDatabase
    {
        void InsertLending(int lenderId, string licenseTag);

        void RemoveLending(int lenderId, string licenseTag);

        void CreateLender(string name, int age, string adress);

        void RemoveLender(int lenderId);

        void ShowLender(int lenderID);

        void CreateCar(string licenseTag, string model, string manufacturer, decimal pricePerDay, int assignedBranchNo);

        void RemoveCar(string licenseTag);

        DataSet LoadData();

        List<string> GetRentedCars(int lenderID);

        void CreateBranch(string name, string adress);

        void RemoveBranch(int branchNo);
    }
}
