using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public string Validar(string rut, string pass)
        {

            string meme = "DATA SOURCE = SesaruGrimm:1521 / XE; USER ID = PORTAFOLIO;Password = portafolio;";
            OracleConnection conn = new OracleConnection(meme);
            conn.Open();

            OracleParameter param = new OracleParameter();
            param.OracleDbType = OracleDbType.Decimal;

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.Parameters.Add(param);
            cmd.CommandText = "SELECT RUT, NOMBRE FROM USUARIO WHERE RUT = '" + rut + "' AND CONTRASEÑA ='" + pass + "'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string us = dr.GetString(1);
            return us;







        }
    }
}
