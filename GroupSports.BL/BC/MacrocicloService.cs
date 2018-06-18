using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupSports.DL;
using GroupSports.DL.DALI;

namespace GroupSports.BL.BC
{
    public class MacrocicloService : IMacrocicloService
    {
        public IMacrocicloRepository MacrocicloRepository { get; set; } = new MacrocicloRepository();

        public List<MACROCICLO> Get()
        {
            try
            {
                return MacrocicloRepository.Get();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public MACROCICLO Get(int id)
        {
            try
            {
                return MacrocicloRepository.Get(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<MACROCICLO> GetByWorkplan(int workplanid)
        {
            try
            {
                return MacrocicloRepository.GetByWorkplan(workplanid);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Add(MACROCICLO macrociclo)
        {
            try
            {
                MacrocicloRepository.Add(macrociclo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Edit(MACROCICLO macrociclo)
        {
            try
            {
                MacrocicloRepository.Edit(macrociclo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                MacrocicloRepository.Delete(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
