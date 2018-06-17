//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using GroupSports.BL.BC;
//using GroupSports.DL.DM;

//namespace GroupSportsWeb.ViewModels
//{
//    public class DeleteTeamViewModel
//    {
//        public int id { get; set; }
//        public string teamName { get; set; }
//        public int coachId { get; set; }
//        public string username { get; set; }

//        public TeamService teamService { get; set; } = new TeamService();
//        public List<team> lstTeam = new List<team>();
//        public team equipo { get; set; } = new team();

//        //internal void FindById(int id)
//        //{
//        //    this.teamService.findById(id);
//        //}

//        internal void FindAll()
//        {
//            this.lstTeam = teamService.findAll();
//        }


//        internal void DeleteTeam(int i)
//        {
//            teamService.deleteTeam(i);
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