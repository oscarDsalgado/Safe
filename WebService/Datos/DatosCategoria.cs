using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Datos
{
    public class DatosCategoria
    {

        public static bool GuardarCategoria(string Item, int id)
        {

            DatosConexion c = new DatosConexion();

            using (OracleConnection conn = c.Connect())
            {

                OracleCommand cmd = new OracleCommand("PKG_EVALUACION.Pro_AgregarCategoria", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_nombre", "varchar2").Value = Item;
                cmd.Parameters.Add("p_estado", "varchar2").Value = "activo";
                cmd.Parameters.Add("p_tipo", "number").Value = id;
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

        //***************

        public static List<ClassLibrary1.categoria> ListarCategoria()
        {
            DatosConexion c = new DatosConexion();

            using (OracleConnection conn = c.Connect())
            {
                 List<categoria> listado = new List<categoria>();
                OracleCommand oracmd = new OracleCommand();
                oracmd.Parameters.Add("ListarCat", OracleDbType.RefCursor, ParameterDirection.Output);
                oracmd.CommandText = "PKG_EVALUACION.Listar_cat";
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
                        categoria ev = new categoria();
                        ev.Id = int.Parse(dr["ID_CAT"].ToString());
                        ev.Nombre = dr["NOMBRE"].ToString();
                        ev.Estado = "Activo";

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

        //************************************************************
        public static List<categoria> listarCategoriaXtipo(int id)
        {
            DatosConexion c = new DatosConexion();
            using (OracleConnection conn = c.Connect())
            {
                List<categoria> listado = new List<categoria>();
                OracleCommand oracmd = new OracleCommand();
                oracmd.Parameters.Add(new OracleParameter("idc", id));
                oracmd.Parameters.Add("ListarCat", OracleDbType.RefCursor, ParameterDirection.Output);
                oracmd.CommandText = "PKG_EVALUACION.Listar_catXtipo";
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
                        categoria ev = new categoria();
                        ev.Id = int.Parse(dr["ID_CAT"].ToString());
                        ev.Nombre = dr["NOMBRE"].ToString();
                        ev.Estado = "Activo";

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

        //*****
        


    }
}
