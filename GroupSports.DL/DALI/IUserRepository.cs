using GroupSports.DL.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSports.DL.DALI
{
    public interface IUserRepository
    {
        List<User> findAll();
        //User findById(int id);
        //List<User> findByName(string name);
        //void insertUser(User user);
        //void updateUser(User user);
        //void deleteUser(int id);
        
    }
}
