using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using ClassLibrary1;

namespace Datos
{
    public class DatosPregunta
    {

        public static bool AgregarPregunta(int idCat, string ask)
        {
            DatosConexion c = new DatosConexion();
            using (OracleConnection conn = c.Connect())
            {
                OracleCommand cmd = new OracleCommand("PKG_EVALUACION.pro_AgregarPreguntas", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_pregunta", "varchar2").Value = ask;
                cmd.Parameters.Add("p_estado", "varchar2").Value = "activo";
                cmd.Parameters.Add("p_cat", "number").Value = idCat;

                try
                {
                   conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

        }

        public static List<Pregunta> ListadoPreguntasXcat(int id)
        {
            DatosConexion c = new DatosConexion();
            using (OracleConnection conn = c.Connect())
            {

                List<Pregunta> listado = new List<Pregunta>();
                OracleCommand oracmd = new OracleCommand();
                oracmd.Parameters.Add(new OracleParameter("idc", id));
                oracmd.Parameters.Add("listarPreguntas", OracleDbType.RefCursor, ParameterDirection.Output);
                oracmd.CommandText = "PKG_EVALUACION.Listar_preguntasXc";
                oracmd.CommandType = CommandType.StoredProcedure;
                oracmd.Connection = conn;
                OracleDataAdapter da = new OracleDataAdapter(oracmd);
                DataSet ds = new DataSet();


                try
                {
                    conn.Open();
                    da.Fill(ds);
                    OracleDataReader dr = oracmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Pregunta ev = new Pregunta();
                        ev.Id = int.Parse(dr["ID_PREGUNTA"].ToString());
                        ev.Pregunta1 = dr["PREGUNTA"].ToString();
                        ev.Estado = dr["ESTADO"].ToString();
                        listado.Add(ev);
                    }
                    conn.Close();
                    return listado;

                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
      
    }
}
