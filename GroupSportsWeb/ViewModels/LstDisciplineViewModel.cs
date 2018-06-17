//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using GroupSports.BL.BC;
//using GroupSports.DL.DM;
//using GroupSports.DL;

//namespace GroupSportsWeb.ViewModels
//{
//    public class LstDisciplineViewModel
//    {
//        group_sportsEntities1 context = new group_sportsEntities1();
//       public List<discipline> lstDiscp = new List<discipline>();
//        public int disciplineId { get; set; }
//        public string disciplineName { get; set; }
//        public string disciplineDescription { get; set; }
        
//        internal void listDisciplines()
//        {
//            lstDiscp = context.discipline.ToList();
//        }

//    }
//}