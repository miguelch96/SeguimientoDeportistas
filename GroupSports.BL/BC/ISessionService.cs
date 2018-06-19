using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupSports.DL;

namespace GroupSports.BL.BC
{
    public interface ISessionService
    {
        List<SESION> Get(int? workweekid);
        SESION Find(int id);
        void Add(SESION sesion);
        void Edit(SESION sesion);
        void Delete(int id);
    }
}
