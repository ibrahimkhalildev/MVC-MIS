using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_MIS.Models
{

    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Mobile> List_Mobile { get; set; }

        public Human()
        {
            List_Mobile = new List<Mobile>();
        }
    }
    public class Mobile
    {
        public string Name { set; get; }
    }
}