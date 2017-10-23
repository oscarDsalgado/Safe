using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Datos
{
    public class DatosConexion
    {

        private string password, user;

        public DatosConexion()
        { }
        ///
/// Permite crear una cadena de conexión tipo Oracle
 /// </summary>
        ///
        public OracleConnection Connect()
        {
            ////////////////////////////////////////////////////////////////////////////////////
            //Referencia estática al usuario y password ingresados en el login de la aplicación/
            ////////////////////////////////////////////////////////////////////////////////////
            user = "GRUPOSAFE";
            password = "portafolio";

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
                throw new Exception("El usuario y el password son datos requeridos");
            
            //ConnectionStrings["ConnectionStringUsers"].ConnectionString;
            string strConnectionString = "DATA SOURCE = 190.161.202.171:1521/DBORACLE; USER ID = GRUPOSAFE;Password = portafolio;";

            //oradb = string.Format(oradb, user, password);
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = strConnectionString;
            return conn;
        }

    }
}
