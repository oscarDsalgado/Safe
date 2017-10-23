using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Datos
{
    public class DatosEvaluaciones
    {

        public static bool AgregarEvaluaciones(string idE, int idT,string rut ,DateTime fecha,string obsTec, string recIng, string estado )
        {
            DatosConexion c = new DatosConexion();
            using (OracleConnection conn = c.Connect())
            {

                OracleCommand cmd = new OracleCommand("PKG_EVALUACION.Pro_AgregarEvaluacion", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_fecha", "date").Value = fecha.Date;
                cmd.Parameters.Add("p_obsTec", "varchar2").Value = obsTec;
                cmd.Parameters.Add("p_recIng", "varchar2").Value = recIng;
                cmd.Parameters.Add("p_estado", "varchar2").Value = "activo";
                cmd.Parameters.Add("p_tipoEva", "varchar2").Value = idT;
                cmd.Parameters.Add("p_empresa", "varchar2").Value = idE;
                cmd.Parameters.Add("p_usuario", "varchar2").Value = rut;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

                return true;
        }

        public static bool ModificacionIngeniero(int idE, string obs)
        {
            DatosConexion c = new DatosConexion();
            using (OracleConnection conn = c.Connect())
            {

                OracleCommand cmd = new OracleCommand("PKG_EVALUACION.Pro_ModificarAgregarIng", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_id", "number").Value = idE;
                cmd.Parameters.Add("p_recIng", "varchar2").Value = obs;
                cmd.Parameters.Add("p_estado", "number").Value = "Aprobada";

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


    }
}
