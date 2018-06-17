using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using GroupSports.DL.Actors;


namespace GroupSports.DL.DALI
{
    public class AthleteRepository:IAthleteRepository
    {
        string strConnection = ConfigurationManager.ConnectionStrings["micadena"].ConnectionString.ToString();

        public List<Athlete> findAll()
        {
            List<Athlete> atletas = new List<Athlete>();
            using (SqlConnection con = new SqlConnection(strConnection))
            {


                SqlCommand cmd = new SqlCommand("sp_Select_Atletas_Join_Usuarios", con);
                //SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    Athlete atleta = new Athlete();
                    atleta.AthleteId = Convert.ToInt32(reader[0]);

                    if (!(reader[1] is DBNull))
                    {
                        atleta.userId = Convert.ToInt32(reader[1]);
                    }
                    else
                    {
                        atleta.userId = null;
                    }
                    if (!(reader[2] is DBNull))
                        {
                           atleta.discipline = Convert.ToInt32(reader[2]);
                        }
                    else
                    {
                        atleta.discipline = null;
                    }

                    if (!(reader[3] is DBNull))
                    {
                        atleta.ageCategory = Convert.ToInt32(reader[3]);
                    }
                    else
                    {
                        atleta.ageCategory = null;
                    }
                    atleta. userLogin= reader[4].ToString();
                    atleta.userPass = reader[5].ToString();
                    atleta.name = reader[6].ToString();
                    atleta.lastName = reader[7].ToString();
                    atleta.cellPhone = reader[8].ToString();
                    atleta.address = reader[9].ToString();
                    atleta.emailAdress = reader[10].ToString();
                    atleta.fechaNac = reader[11].ToString();
                    if (!(reader[12] is DBNull))
                    {
                        atleta.userType = Convert.ToInt16(reader[12]);
                    }
                    else
                    {
                        atleta.userType = null;
                    }

                    //if (!(reader[9] is DBNull))
                    //{
                    //    usuario.userType = Convert.ToInt16(reader[9]);
                    //}
                    //else
                    //{
                    //    usuario.userType = null;
                    //}
                    //usuario.fechaNac = reader[8].ToString();

                    atletas.Add(atleta);
                }

            }
            return atletas;
        }
    }
}
