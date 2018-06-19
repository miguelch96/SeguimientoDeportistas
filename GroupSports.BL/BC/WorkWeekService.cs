using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupSports.DL;
using GroupSports.DL.DALI;

namespace GroupSports.BL.BC
{
    public class WorkWeekService : IWorkWeekService
    {
        public IWorkWeekRepository WorkWeekRepository { get; set; } = new WorkWeekRepository();
        public List<WORKWEEK> Get(int? mesocicloid)
        {
            return WorkWeekRepository.Get(mesocicloid);
        }

        public WORKWEEK Find(int id)
        {
            return WorkWeekRepository.Find(id);
        }

        public void Add(WORKWEEK workweek)
        {
            WorkWeekRepository.Add(workweek);
        }

        public void Edit(WORKWEEK workweek)
        {
            WorkWeekRepository.Edit(workweek);
        }

        public void Delete(int id)
        {
            WorkWeekRepository.Delete(id);
        }
    }
}
