using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;

namespace WebService
{
    public class conexion
    {
        public static bool validarconexion()
        {
            string strConnectionString = "DATA SOURCE = 190.163.62.242:1521 / DBORACLE; USER ID = GRUPOSAFE;Password = portafolio;";
            OracleConnection oraconn = new OracleConnection(strConnectionString);
            if (oraconn != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}