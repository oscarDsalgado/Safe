using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Oracle.DataAccess.Client;
using System.Data;



namespace WSsinModelo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public string Validar(string rut,string pass) {

            string meme = "DATA SOURCE = SesaruGrimm:1521 / XE; USER ID = PORTAFOLIO;Password = portafolio;";
            OracleConnection conn = new OracleConnection(meme);
            conn.Open();

            OracleParameter param = new OracleParameter();
            param.OracleDbType = OracleDbType.Decimal;

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.Parameters.Add(param);
            cmd.CommandText = "SELECT RUT, NOMBRE FROM USUARIO WHERE RUT = '"+rut+"' AND CONTRASEÑA ='"+pass+"'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string us = dr.GetString(1);
            return us;







        }
    }
}
