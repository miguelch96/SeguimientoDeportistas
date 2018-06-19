using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupSports.DL;
using GroupSports.DL.DALI;

namespace GroupSports.BL.BC
{
    public class SesionService : ISessionService
    {
        public ISessionRepository SessionRepository { get; set; } = new SessionRepository();
        public List<SESION> Get(int? workweekid)
        {
            return SessionRepository.Get(workweekid);
        }

        public SESION Find(int id)
        {
            return SessionRepository.Find(id);
        }

        public void Add(SESION sesion)
        {
            SessionRepository.Add(sesion);
        }

        public void Edit(SESION sesion)
        {
            SessionRepository.Edit(sesion);
        }

        public void Delete(int id)
        {
            SessionRepository.Delete(id);
        }
    }
}
