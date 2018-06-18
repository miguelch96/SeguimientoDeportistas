using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GroupSports.DL;

namespace GroupSportsWeb.ViewModels.Macrociclos
{
    public class LstMacrociclosViewModel
    {
        public List<MACROCICLO> LstMacrociclos { get; set; }
        public WORKPLAN Workplan { get; set; }
    }
}