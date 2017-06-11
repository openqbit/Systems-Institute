using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQbit.Institute.DAL.DataAccess;
using OpenQbit.Institute.Common.Models;

namespace OpenQbit.Institute.BLL.InstituteService1
{
    class BranchManager
    {
        private Repository _db = new Repository();


        public bool CreateBranch(string BranchName, string Address, int TelNo, int InstituteId)
        {
            Branch newBranch = new Branch();
            return _db.Create<Branch>(newBranch);
        }

        public bool RemoveBranch(int BranchID)
        {
            Branch newBranch = new Branch();
            return _db.Delete<Branch>(newBranch);
        }
        public bool RemoveBranch(string BranchName)
        {
            Branch newBranch = new Branch();
            return _db.Delete<Branch>(newBranch);
        }
        public Branch FindDocument(int BranchId)
        {
            Branch newBranch = new Branch();
            return _db.FindList<Branch>(BranchId);
        }
    }
}
