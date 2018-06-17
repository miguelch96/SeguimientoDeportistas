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
    public class WorkWeekRepository:IWorkWeekRepository
    {
        string strConnection = ConfigurationManager.ConnectionStrings["micadena"].ConnectionString.ToString();

        public List<WorkWeek> findAll(int id)
        {
            List<WorkWeek> semanas = new List<WorkWeek>();
            using (SqlConnection con = new SqlConnection(strConnection))
            {


                SqlCommand cmd = new SqlCommand("sp_Select_Semanas_from_Mesociclo", con);
                //SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MesocicloId", id);
                
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    WorkWeek semana = new WorkWeek();
                    semana.weekId = Convert.ToInt32(reader[0]);
                    semana.weekName = reader[1].ToString();
                    semana.weekObjective = reader[2].ToString();

                    if (!(reader[3] is DBNull))
                    {
                        semana.mesocicloId = Convert.ToInt32(reader[3]);
                    }
                    else
                    {
                        semana.mesocicloId = null;
                    }
                    semana.mesocicleName = reader[4].ToString();
                    semana.mesocicleObjective = reader[5].ToString();

                    if (!(reader[6] is DBNull))
                    {
                        semana.macrocicleId = Convert.ToInt32(reader[6]);
                    }
                    else
                    {
                        semana.macrocicleId = null;
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

                    semanas.Add(semana);
                }

            }
            return semanas;
        }
    }
}
