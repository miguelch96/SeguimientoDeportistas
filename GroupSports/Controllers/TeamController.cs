//using GroupSports.BL.BC;
//using GroupSports.DL.DM;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;

//namespace GroupSports.Controllers
//{
//    public class TeamController : ApiController
//    {
//        ITeamService userService = new TeamService();
//        // GET: api/Team
//        public List<team> Get()
//        {
//            return userService.findAll();
//        }

//        // GET: api/Team/5
//        public team Get(int id)
//        {
//            return userService.findById(id);
//        }

//        // POST: api/Team
//        public void Post([FromBody]team value)
//        {
//            userService.insertTeam(value);
//        }

//        // PUT: api/Team/5
//        public void Put([FromBody]team value)
//        {
//            userService.updateTeam(value);
//        }

//        // DELETE: api/Team/5
//        public void Delete(int id)
//        {
//            userService.deleteTeam(id);
//        }
//    }
//}
