using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupSports.DL.Actors;
using GroupSports.DL.DALI;

namespace GroupSports.BL.BC
{
   public class AthleteService:IAthleteService
    {
        IAthleteRepository athleteRepository = new AthleteRepository();
        //public void deleteUser(int user)
        //{
        //    userRepository.deleteUser(user);
        //}

        public List<Athlete> findAll()
        {
            return athleteRepository.findAll();
        }

    }
}
