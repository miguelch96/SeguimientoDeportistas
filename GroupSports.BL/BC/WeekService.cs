using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupSports.DL.DALI;
using GroupSports.DL;
using GroupSports.DL.Actors;

namespace GroupSports.BL.BC
{
    public class WeekService: IWeekService
    {
        IWorkWeekRepository WeekRepository = new WorkWeekRepository();
        public List<WorkWeek> findAll(int id)
        {
            return WeekRepository.findAll(id);
        }
    }
}
