using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing
{
    class Branch
    {
        private int branchNo;
        private string name;
        private string adress;

        public Branch(int branchNo, string name, string adress)
        {
            this.branchNo = branchNo;
            this.name = name;
            this.adress = adress;
        }

        public void SetBranchNo(int branchNo)
        {
            this.branchNo = branchNo;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAdress(string adress)
        {
            this.adress = adress;
        }

        public int SetBranchNo()
        {
            return this.branchNo;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetAdress()
        {
            return this.adress;
        }

    }
}
