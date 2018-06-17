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
//    public class UserController : ApiController
//    {
//        IUserService userService = new UserService();
//        // GET: api/user
//        public List<user> Get()
//        {
//            return userService.findAll();
//        }

//        // GET: api/user/5
//        public user Get(int id)
//        {
//            return userService.findById(id);
//        }

//        // POST: api/user
//        public void Post([FromBody]user value)
//        {
//            userService.insertUser(value);
//        }

//        // PUT: api/user/5
//        public void Put([FromBody]user value)
//        {
//            userService.updateUser(value);
//        }

//        // DELETE: api/user/5
//        public void Delete(int id)
//        {
//            userService.deleteUser(id);
//        }
//    }
//}
