using System;
using System.Collections.Generic;
using GroupSports.DL.Actors;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSports.DL.DALI
{
    public interface IWorkWeekRepository
    {
        List<WorkWeek> findAll(int id);

    }
}
