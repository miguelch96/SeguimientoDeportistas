using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupSports.DL;
using GroupSports.DL.DALI;

namespace GroupSports.BL.BC
{
    public class CoachService : ICoachService
    {
        public ICoachRepository CoachRepository { get; set; } = new CoachRepository();
        public List<COACH> Get()
        {
            return CoachRepository.Get();
        }

        public COACH Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(COACH coach)
        {
            throw new NotImplementedException();
        }

        public void Edit(COACH coach)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
