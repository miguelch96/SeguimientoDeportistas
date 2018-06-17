//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using GroupSports.BL.BC;
//using GroupSports.DL.DM.DTO;
//using GroupSports.DL.DALI;
//using GroupSports.DL.DM;

//namespace GroupSportsWeb.ViewModels
//{
//    public class EditCoachViewModel
//    {
//        public List<CoachDTO> lstCoach = new List<CoachDTO>();
//        public CoachService coachService = new CoachService();
//        public int id { get; set; }
//        public string username { get; set; }
//        public string password { get; set; }
//        public int userType { get; set; }
//        public string firstName { get; set; }
//        public string lastName { get; set; }
//        public string cellPhone { get; set; }
//        public string address { get; set; }
//        public string emailAddress { get;set; }
//        public int edad { get; set; }
//        public int yearsOfExperience { get; set; }
//        public int userId { get; set; }
       


//        internal void Fill()
//        {
//            this.lstCoach = coachService.findAll();
//        }
//        internal void FindById(int id)
//        {
//            CoachDTO coach = coachService.findById(id);
//            this.username = coach.username;
//            this.firstName = coach.firstName;
//            this.lastName = coach.lastName;
//            this.userId = coach.userId;
//            this.userType = coach.userType;
//            this.yearsOfExperience = coach.yearsOfExperience;
//            this.address = coach.address;
//            this.cellPhone = coach.cellPhone;
//            this.edad = coach.edad;
//            this.emailAddress = coach.emailAddress;
           
//        }
//        internal void EditCoach(CoachDTO coachDTO)
//        {
//            this.coachService.updateCoach(coachDTO);
//        }
//    }
//}