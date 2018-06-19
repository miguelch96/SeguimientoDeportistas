using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSports.DL.DALI
{
    public interface IMacrocicloRepository
    {
        List<MACROCICLO> Get(int? workplanid);
        MACROCICLO Find(int id);
        void Add(MACROCICLO macrociclo);
        void Edit(MACROCICLO macrociclo);
        void Delete(int id);
    }
}
