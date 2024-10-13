using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_MIS.Models
{
    public class Branch
    {
        public string BranchName { get; set; }
        public int BranchCode { get; set; }

        public static List<Branch> GetBranch()
        {
            List<Branch> lst = new List<Branch>();
            
            Branch branch = new Branch();
            branch.BranchName = "Dhaka";
            branch.BranchCode = 113;
            lst.Add(branch);

            branch = new Branch();
            branch.BranchName = "Khulna";
            branch.BranchCode = 601;
            lst.Add(branch);

            return lst;
        }

    }
}