using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupSports.DL.Actors;

namespace GroupSports.DL.DALI
{
    public interface ISessionRepository
    {
        List<Session> findAll(int semanaId);

    }
}
