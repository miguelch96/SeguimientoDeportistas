using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupSports.DL.Actors;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace GroupSports.DL.DALI
{
    public class UserRepository : IUserRepository
    {
        
        string strConnection = ConfigurationManager.ConnectionStrings["micadena"].ConnectionString.ToString();

        public List<User> findAll()
        {
            List<User> usuarios = new List<User>();
            using (SqlConnection con = new SqlConnection(strConnection))
            {


                SqlCommand cmd = new SqlCommand("sp_Select_from_usuario", con);
                //SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User usuario = new User();
                    usuario.userId = Convert.ToInt16(reader[0]);
                    usuario.userLogin = reader[1].ToString();
                    usuario.userPass = reader[2].ToString();
                    usuario.name = reader[3].ToString();
                    usuario.lastName = reader[4].ToString();
                    usuario.cellPhone = reader[5].ToString();
                    usuario.address = reader[6].ToString();
                    usuario.emailAdress = reader[7].ToString();
                    if (!(reader[9] is DBNull))
                    {
                        usuario.userType = Convert.ToInt16(reader[9]);
                    }
                    else
                    {
                        usuario.userType = null;
                    }
                    usuario.fechaNac = reader[8].ToString();

                    usuarios.Add(usuario);
                }

            }
            return usuarios;
        }

        


    }
}
