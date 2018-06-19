using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GroupSports.DL;

namespace GroupSportsWeb.ViewModels.Mesociclos
{
    public class LstMesociclosViewModel
    {
        public List<MESOCICLO> LstMesociclos { get; set; } = new List<MESOCICLO>();
        public MACROCICLO Macrociclo { get; set; }
    }
}