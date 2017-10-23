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
    public class DatosTipoEvaluacion
    {
        public static List<TipoEvaluacion> ListarTipo()
        {

            DatosConexion c = new DatosConexion();


            using (OracleConnection conn = c.Connect())
            {
                List<TipoEvaluacion> listado = new List<TipoEvaluacion>();
                OracleCommand oracmd = new OracleCommand();
                oracmd.Parameters.Add("listarEval", OracleDbType.RefCursor, ParameterDirection.Output);
                oracmd.CommandText = "PKG_EVALUACION.ListarTipoEval";
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
                        TipoEvaluacion ev = new TipoEvaluacion();
                        ev.Id = int.Parse(dr["ID_TIPO"].ToString());
                        ev.Nombre = dr["NOMBRE_TIPO"].ToString();

                        listado.Add(ev);
                    }


                    conn.Close();
                    return listado;

                }
                catch (Exception ex)
                {
                    conn.Close();
                    throw ex;
                }


            } 
               
        }





    }
}
