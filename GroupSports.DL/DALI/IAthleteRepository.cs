using GroupSports.DL.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSports.DL.DALI
{
    public interface IAthleteRepository
    {
        List<Athlete> findAll();

    }
}
