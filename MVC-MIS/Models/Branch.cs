using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_MIS.Models
{
    public class Branch
    {
        public string BranchName { get; set; }
        public string Location { get; set; }
        public int BranchCode { get; set; }
      

        public static List<Branch> GetBranches()
        {
            List<Branch> lst = new List<Branch>();
            
            Branch branch = new Branch();
            branch.BranchName = "Dhaka Branch";
            branch.Location = "New Market";
            branch.BranchCode = 113;
            lst.Add(branch);

            branch = new Branch();
            branch.BranchName = "Khulna Branch";
            branch.Location = "Amtala Bazar"; ;
            branch.BranchCode = 601;
            lst.Add(branch);

            branch = new Branch();
            branch.BranchName = "Chattogram";
            branch.Location = "Oxizen";
            branch.BranchCode = 906;
            lst.Add(branch);

            return lst;
        }
    }
}