//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using GroupSports.BL.BC;
//using GroupSports.DL.DM;

//namespace GroupSportsWeb.ViewModels
//{
//    public class EditTeamViewModel
//    {
//        public int id { get; set; }
//        public string teamName { get; set; }
//        public int coachId { get; set; }
//        public TeamService teamService { get; set; } = new TeamService();
//        public List<team> lstTeam = new List<team>();
//        public team equipo { get; set; } = new team();


//        internal void EditTeam(team t)
//        {
//            teamService.updateTeam(t);
//        }
//        internal void FindTeam(int id)
//        {
//            teamService.findById(id);
//        }
//        internal void FindById(int id)
//        {
//            team equipo = teamService.findById(id);
//            this.id = equipo.id;
//            this.teamName = equipo.teamName;
//            this.coachId = equipo.coachId;
           
       

//        }
//    }
//}