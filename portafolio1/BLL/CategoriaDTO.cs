using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoriaDTO
    {
        ServiceReference1.wsa1SoapClient ws = new ServiceReference1.wsa1SoapClient();

       

        public List<ServiceReference1.categoria> listarCategoria()
        {
            ServiceReference1.categoria cat = new ServiceReference1.categoria();
            return ws.E_listadoCategoria();
        }



    }
}
