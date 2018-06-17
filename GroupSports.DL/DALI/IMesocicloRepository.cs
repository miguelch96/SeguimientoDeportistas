using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupSports.DL.Actors;


namespace GroupSports.DL.DALI
{
    interface IMesocicloRepository
    {
        List<Mesociclo> findWorkWeeksByMesocicle(int id);
    }
}
