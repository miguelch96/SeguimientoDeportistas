using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupSports.DL;
using GroupSports.DL.DALI;

namespace GroupSports.BL.BC
{
    public class MesocicloService : IMesocicloService
    {
        public IMesocicloRepository MesocicloRepository { get; set; } = new MesocicloRepository();

        public List<MESOCICLO> Get(int? macrocicloid)
        {
            return MesocicloRepository.Get(macrocicloid);
        }

        public MESOCICLO Find(int id)
        {
            return MesocicloRepository.Find(id);
        }

        public void Add(MESOCICLO mesociclo)
        {
            MesocicloRepository.Add(mesociclo);
        }

        public void Edit(MESOCICLO mesociclo)
        {
            MesocicloRepository.Edit(mesociclo);
        }

        public void Delete(int id)
        {
            MesocicloRepository.Delete(id);
        }
    }
}
