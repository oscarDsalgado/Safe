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
    public class DatosEmpresa
    {
        public static List<empresa> ListadoEmpresas()
        {
           
            DatosConexion c = new DatosConexion();
            using (OracleConnection conn =c.Connect())
            {
                List<empresa> listado = new List<empresa>();
                OracleCommand oracmd = new OracleCommand();
                oracmd.Parameters.Add("listarE", OracleDbType.RefCursor, ParameterDirection.Output);
                oracmd.CommandText = "PKG_EVALUACION.ListarEMP";
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
                        empresa ev = new empresa();
                        ev.rut_empresa= dr["RUT_EMPRESA"].ToString();
                        ev.nombre_empresa = dr["NOMBRE"].ToString();

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
