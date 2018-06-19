using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupSports.DL;

namespace GroupSports.BL.BC
{
    public interface IWorkWeekService
    {
        List<WORKWEEK> Get(int? mesocicloid);
        WORKWEEK Find(int id);
        void Add(WORKWEEK workweek);
        void Edit(WORKWEEK workweek);
        void Delete(int id);
    }
}
