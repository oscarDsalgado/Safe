using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using ClassLibrary1;
using System.Data;

namespace Datos
{
    public class DatosDetalle_evaluacion
    {
        public static bool Agregar_detalle(int idE, int idP, string p)
        {
            DatosConexion c = new DatosConexion();
            using (OracleConnection conn = c.Connect())
            {
                OracleCommand cmd = new OracleCommand("PKG_EVALUACION.Pro_AgregarCategoria", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_respuesta", "varchar2").Value = p;
                cmd.Parameters.Add("p_id_eval", "number").Value = idE;
                cmd.Parameters.Add("p_id_pre", "number").Value = idP;

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

        }




    }
}
