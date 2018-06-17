using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GroupSports.BL.BC;
using GroupSports.DL.Actors;

namespace GroupSportsWeb.ViewModels
{
    public class LstAthleteViewModel
    {
        AthleteService athleteService = new AthleteService();
        public List<Athlete> lstatletas = new List<Athlete>();
      

        public void findAll()
        {
            lstatletas = athleteService.findAll();
        }
    }
}