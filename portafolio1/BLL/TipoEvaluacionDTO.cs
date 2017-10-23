using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TipoEvaluacionDTO
    {


        private int id;
        private string nombre;
        private string estado;


        public TipoEvaluacionDTO()
        {

        }

       

        public TipoEvaluacionDTO(int id, string nombre, string estado)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Estado { get => estado; set => estado = value; }


        ServiceReference1.wsa1SoapClient ws = new ServiceReference1.wsa1SoapClient();

        public List<ServiceReference1.TipoEvaluacion> ListarTipos()
        {
            
            ServiceReference1.TipoEvaluacion t = new ServiceReference1.TipoEvaluacion();

            return ws.E_listarTipoEvaluacione().ToList();
        }


    }
}
