using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TipoEvaluacionDTO
    {

        ServiceReference1.wsa1SoapClient ws = new ServiceReference1.wsa1SoapClient();

        public List<ServiceReference1.TipoEvaluacion> ListarTipos()
        {
            
            ServiceReference1.TipoEvaluacion t = new ServiceReference1.TipoEvaluacion();

            return ws.E_listarTipoEvaluacione().ToList();
        }


    }
}
