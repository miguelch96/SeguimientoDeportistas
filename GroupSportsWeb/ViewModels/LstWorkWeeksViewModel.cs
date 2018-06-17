using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GroupSports.BL.BC;
using GroupSports.DL.Actors;

namespace GroupSportsWeb.ViewModels
{
    public class LstWorkWeeksViewModel
    {
        WeekService weekService = new WeekService();
        public List<WorkWeek> listaSemanasPorMesociclo = new List<WorkWeek>();

        public void findAll(int id)
        {
            listaSemanasPorMesociclo = weekService.findAll(id);

        }
    }
}