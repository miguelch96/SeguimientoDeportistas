using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupSports.DL;

namespace GroupSports.BL.BC
{
    public interface ICoachService
    {
        List<COACH> Get();
        COACH Find(int id);
        void Add(COACH coach);
        void Edit(COACH coach);
        void Delete(int id);
    }
}
