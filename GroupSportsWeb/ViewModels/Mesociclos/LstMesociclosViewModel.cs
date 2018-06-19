using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GroupSports.DL;

namespace GroupSportsWeb.ViewModels.Mesociclos
{
    public class LstMesociclosViewModel
    {
        public List<MESOCICLO> LstMesociclos { get; set; }
        public MACROCICLO Macrociclo { get; set; }
    }
}