using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GroupSports.DL;

namespace GroupSportsWeb.ViewModels.WorkWeeks
{
    public class LstWorkWeeksViewModel
    {
        public List<WORKWEEK> LstWorkweeks { get; set; }
        public MESOCICLO Mesociclo { get; set; }
    }
}