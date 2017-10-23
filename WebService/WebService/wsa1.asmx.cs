using ClassLibrary1;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Descripción breve de wsa1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsa1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string Validar(string rut, string pass, string tipo)
        {
            string us = "";
            string rut_login = "";
            if (tipo == "EMPRESA")
            {
                rut_login = "RUT_EMPRESA";
            }
            else {
                rut_login = "RUT_USUARIO";
            }
            string meme = "DATA SOURCE = 190.161.202.171:1521 / DBORACLE; USER ID = GRUPOSAFE;Password = portafolio;";
            OracleConnection conn = new OracleConnection(meme);
            try
            {

                conn.Open();

                OracleParameter param = new OracleParameter();
                param.OracleDbType = OracleDbType.Decimal;

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.Parameters.Add(param);
                cmd.CommandText = "SELECT " + rut_login + " , NOMBRE, ESTADO FROM " + tipo + " WHERE " + rut_login + " = '" + rut + "' AND CONTRASEÑA ='" + pass + "'";
                cmd.CommandType = CommandType.Text;



                try
                {
                    cmd.ExecuteNonQuery();
                    OracleDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    if (dr.GetString(2) == "inactivo")
                    {
                        us = "malo";
                       
                    }
                    else
                    {
                        us = dr.GetString(1);
                  
                    }



                }
                catch (Exception)
                {

                    us = "nulo";
                
                }

            }
            catch (Exception)
            {
                us = "server";
               
            }
            conn.Close();
            return us;







        }
        //********************************************************************************
        

        [WebMethod]
        public string DevuelveTipo(string rut, string tipo)
        {
            string str = "DATA SOURCE=190.161.202.171:1521/DBORACLE;USER ID=GRUPOSAFE; Password=portafolio";

            OracleConnection conn = new OracleConnection(str);
            string us = "";
            
            if (tipo == "Usuario")
            {
                //string meme = "DATA SOURCE = 190.163.62.242:1521 / DBORACLE; USER ID = GRUPOSAFE;Password = portafolio;";
                // OracleConnection conn = new OracleConnection(meme);
                // conn.Open();

                // OracleParameter param = new OracleParameter();
                // param.OracleDbType = OracleDbType.Decimal;

                // OracleCommand cmd = new OracleCommand();
                // cmd.Connection = conn;
                // cmd.Parameters.Add(param);
                // cmd.CommandText = "SELECT RUT_USUARIO, TIPO_USR_ID_TIPO FROM USUARIO WHERE RUT_USUARIO = '" + rut + "'";
                // cmd.CommandType = CommandType.Text;
                // cmd.ExecuteNonQuery();
                // OracleDataReader dr = cmd.ExecuteReader();
                // dr.Read();
                 

                // try
                // {
                //     us = dr.GetString(1);
                // }

          
             
            try
            {
                conn.Open();

                //se escoge el pakete y despues el procedimiento 
                OracleCommand oracmd = new OracleCommand();

                oracmd.CommandText = "PROCEDIMIENTO_USUARIO.SELECT_TIPO";
                oracmd.CommandType = CommandType.StoredProcedure;
                oracmd.Connection = conn;

                //Se colocan las variables del procedimiento el tipo y despues la variable con el dato
                oracmd.Parameters.Add("RUT", "varchar2").Value = rut;
                oracmd.Parameters.Add("listarsalida", OracleDbType.RefCursor, ParameterDirection.Output);
                oracmd.ExecuteNonQuery();
                OracleDataReader reader;
                try
                {
                    reader = oracmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader.GetString(0) == "Administrador")
                        {
                            us = "nope";
                            //conn.Close();
                        }
                        else
                        {
                            us = reader.GetString(0);
                            //conn.Close();
                        }
                    }
                }

                catch (Exception)
                {
                    us = "tipo_nulo";
                   
                }
                


            }
            catch (Exception)
            {
                
                us = "server";
              
            }

            }
            else
            {
                us = "Cliente";
                
            }
            conn.Close(); 
            return us;
            

        }

        //*******************************************************************************


          [WebMethod]
          public List<empresa> GetlistarEmpresaList()
          {




              string strConnectionString = "DATA SOURCE = 190.161.202.171:1521 / DBORACLE; USER ID = GRUPOSAFE;Password = portafolio;";
              OracleConnection oraconn = new OracleConnection(strConnectionString);
              oraconn.Open();
              OracleCommand oracmd = new OracleCommand();
              oracmd.Parameters.Add("listarEmpr", OracleDbType.RefCursor, ParameterDirection.Output);
              oracmd.CommandText = "pkg_empresas.listarEmpresa";
              oracmd.CommandType = CommandType.StoredProcedure;
              oracmd.Connection = oraconn;
              OracleDataAdapter da = new OracleDataAdapter(oracmd);
              DataSet ds = new DataSet();
              List<empresa> milista = new List<empresa>();
              da.Fill(ds);
              foreach (DataRow row in ds.Tables[0].Rows)
              {
                  empresa nueva = new empresa();
                  nueva.rut_empresa = row[0].ToString();
                  nueva.nombre_empresa = row[1].ToString();
                  milista.Add(nueva);
                  //milista.Add(string.Format("{0}" + " " + "{1}", row["RUT_EMPRESA"], row["NOMBRE"]));
              }
              oraconn.Close();
              return milista;
              
          }

          [WebMethod]
          public List<cap_tipo> GetListarTipoCap()
          {
              string strConnectionString = "DATA SOURCE = 190.161.202.171:1521 / DBORACLE; USER ID = GRUPOSAFE;Password = portafolio;";
              OracleConnection oraconn = new OracleConnection(strConnectionString);
              oraconn.Open();
              OracleCommand oracmd = new OracleCommand();
              oracmd.Parameters.Add("listarCAP", OracleDbType.RefCursor, ParameterDirection.Output);
              oracmd.CommandText = "PROCEDIMIENTO_TCAP.LISTAR_TIPO_CAP";
              oracmd.CommandType = CommandType.StoredProcedure;
              oracmd.Connection = oraconn;
              OracleDataAdapter da = new OracleDataAdapter(oracmd);
              DataSet ds = new DataSet();
              List<cap_tipo> milista = new List<cap_tipo>();
              da.Fill(ds);
              foreach (DataRow row in ds.Tables[0].Rows)
              {
                  cap_tipo nueva = new cap_tipo();
                  nueva.id = Int32.Parse(row[0].ToString());
                  nueva.nombre = row[1].ToString();
                  milista.Add(nueva);
                  //milista.Add(string.Format("{0}" + " " + "{1}", row["RUT_EMPRESA"], row["NOMBRE"]));
              }
              oraconn.Close();
              return milista;
             
          }



        //********************************************************************************************
       
        [WebMethod]
        public  bool GuardarCapacitacion(string area,DateTime fecha, string tema,string expo,int asisten,string empresa,int tipocap )
        {
            string strConnectionString = "DATA SOURCE = 190.161.202.171:1521 / DBORACLE; USER ID = GRUPOSAFE;Password = portafolio;";
            OracleConnection oraconn = new OracleConnection(strConnectionString);
            try
            {
                oraconn.Open();
                OracleCommand cmd = new OracleCommand("PROCEDIMIENTO_CAPACITACIONES.AGREGAR_CAPACITACION", oraconn);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                DateTime fecha1 = DateTime.Now.Date;

                cmd.Parameters.Add("ARECAP", "varchar2").Value = area;
                // cmd.Parameters.Add("FECHA", System.Data.SqlDbType.DateTime) = fecha;
                cmd.Parameters.Add("FECHA", "date").Value = fecha.ToShortDateString();
                cmd.Parameters.Add("TEMA", "varchar2").Value = tema;
                cmd.Parameters.Add("EXPOSITOR", "varchar2").Value = expo;
                cmd.Parameters.Add("ASISTENCIA", "number").Value = asisten;
                cmd.Parameters.Add("EMPRESA", "varchar2").Value = empresa;
                cmd.Parameters.Add("TIPO", "number").Value = tipocap;

                //falta estado?

                cmd.ExecuteNonQuery();
                oraconn.Close();
                return true;
            }
            catch (Exception)
            {
                
                return false;
            }
        }


        [WebMethod]
        public List<area> listarArea()
        {




            string strConnectionString = "DATA SOURCE = 190.161.202.171:1521 / DBORACLE; USER ID = GRUPOSAFE;Password = portafolio;";
            OracleConnection oraconn = new OracleConnection(strConnectionString);
            oraconn.Open();
            OracleCommand oracmd = new OracleCommand();
            oracmd.Parameters.Add("LISTA", OracleDbType.RefCursor, ParameterDirection.Output);
            oracmd.CommandText = "CARGO_TIPO_US.LISTAR_AREA";
            oracmd.CommandType = CommandType.StoredProcedure;
            oracmd.Connection = oraconn;
            OracleDataAdapter da = new OracleDataAdapter(oracmd);
            DataSet ds = new DataSet();
            List<area> milista = new List<area>();
            da.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                area nueva = new area();
                nueva.id = Int32.Parse(row[0].ToString());
                nueva.nombre_area = row[1].ToString();
                milista.Add(nueva);
                //milista.Add(string.Format("{0}" + " " + "{1}", row["RUT_EMPRESA"], row["NOMBRE"]));
            }
            oraconn.Close();
            return milista;

        }



        [WebMethod]
        public List<capacitacion> ListarCapacitaciones()
        {

            List<capacitacion> listado = new List<capacitacion>();
            if (conexion.validarconexion())
            {
                string strConnectionString = "DATA SOURCE = 190.161.202.171:1521 / DBORACLE; USER ID = GRUPOSAFE;Password = portafolio;";
                OracleConnection oraconn = new OracleConnection(strConnectionString);
                oraconn.Open();
                OracleCommand oracmd = new OracleCommand();
                oracmd.Parameters.Add("listarCAP", OracleDbType.RefCursor, ParameterDirection.Output);
                oracmd.CommandText = "PROCEDIMIENTO_CAPACITACIONES.LISTAR_CAPACITACIONES";
                oracmd.CommandType = CommandType.StoredProcedure;
                oracmd.Connection = oraconn;
                OracleDataAdapter da = new OracleDataAdapter(oracmd);
                DataSet ds = new DataSet();
                da.Fill(ds);



                OracleDataReader dr = oracmd.ExecuteReader();



                while (dr.Read())
                {
                    capacitacion cap = new capacitacion();
                    cap.Id = int.Parse(dr["ID_CAP"].ToString());
                    cap.Area = dr["AREA_CAPACITACION"].ToString();
                    

                    cap.Fecha = dr["FECHA"].ToString().Substring(0, 11);
                    cap.Tema = dr["TEMA"].ToString();
                    cap.Expositor = dr["EXPOSITOR"].ToString();
                    cap.Asistencia = int.Parse(dr["ASISTENCIA_MIN"].ToString());
                    cap.Rut_empresa = dr["NOMBRE"].ToString();
                    cap.Tipo_cap = dr["TIPO"].ToString(); 

                    listado.Add(cap);
                }


                return listado;
            }
            else
            {
                return listado;
            }

        }
        //**************************************************************************************
        //*****************Ws Modulo evaluaciones
        //ws Categoria
        [WebMethod]
        public bool E_guardarCategoria(string cat, int id)
        {
            return Datos.DatosCategoria.GuardarCategoria(cat, id);
        }


        [WebMethod]
        public List<categoria> E_listadoCategoria()
        {
            return Datos.DatosCategoria.ListarCategoria();
        }

        [WebMethod]
        public List<categoria> E_listarCategoriasXtipo(int id)
        {
            return Datos.DatosCategoria.listarCategoriaXtipo(id);
        }

        //WS pregunta
        [WebMethod]
        public bool E_agregarPregunta(int id, string p)
        {
            return Datos.DatosPregunta.AgregarPregunta(id, p);
        }
        [WebMethod]
        public List<Pregunta> E_listarPreguntaXcategoria(int id)
        {
            return Datos.DatosPregunta.ListadoPreguntasXcat(id);
        }

        //wsEmpresa
        [WebMethod]
        public List<empresa> E_listarempresa()
        {
            return Datos.DatosEmpresa.ListadoEmpresas();
        }
        //Tipo Evaluaciones
        [WebMethod]
        public List<TipoEvaluacion> E_listarTipoEvaluacione()
        {
            return Datos.DatosTipoEvaluacion.ListarTipo();
        }
        //evaluacion
        [WebMethod]
        public bool E_agregarEvaluacion(string idE, int idT, string rut, DateTime fecha, string obsTec, string recIng, string estado)
        {
            return Datos.DatosEvaluaciones.AgregarEvaluaciones(idE,idT,rut,fecha,obsTec,recIng,estado);
        }

        [WebMethod]
        public bool E_modificarEvaluacion(int id, string p)
        {
            return Datos.DatosEvaluaciones.ModificacionIngeniero(id,p);
        }



    }





}
