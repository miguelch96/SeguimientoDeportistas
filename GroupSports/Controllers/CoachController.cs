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
//    public class CoachController : ApiController
//    {
//        ICoachService coachService = new CoachService();
//        // GET: api/Coach
//        public List<CoachDTO> Get()
//        {
//            return coachService.findAll();
//        }

//        // GET: api/Coach/5
//        public CoachDTO Get(int id)
//        {
//            return coachService.findById(id);
//        }

//        // POST: api/Coach
//        public void Post([FromBody]CoachDTO value)
//        {
//            coachService.insertCoach(value);
//        }

//        // PUT: api/Coach/5
//        public void Put([FromBody]CoachDTO value)
//        {
//            coachService.updateCoach(value);
//        }

//        // DELETE: api/Coach/5
//        public void Delete(int id)
//        {
//            coachService.deleteCoach(id);
//        }
//    }
//}
