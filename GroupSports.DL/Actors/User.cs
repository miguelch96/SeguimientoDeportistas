﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSports.DL.Actors
{
    public class User
    {
        public string userLogin { get; set; }
        public string userPass { get; set; }
        public int userId { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string cellPhone { get; set; }
        public string address { get; set; }
        public string emailAdress { get; set; }
        public string fechaNac { get; set; }
        public int? userType { get; set; }


    }
}
