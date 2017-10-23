using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoriaDTO
    {

        private int id_cat;
        private string nombre;
        private string estado;
        private int id;





        ServiceReference1.wsa1SoapClient ws = new ServiceReference1.wsa1SoapClient();

        public CategoriaDTO(int id_cat, string nombre, string estado, int id)
        {
            this.Id_cat = id_cat;
            this.Nombre = nombre;
            this.Estado = estado;
            this.Id = id;
        }


        public int Id_cat { get => id_cat; set => id_cat = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Id { get => id; set => id = value; }

        public List<ServiceReference1.categoria> listarCategoria()
        {
            ServiceReference1.categoria cat = new ServiceReference1.categoria();
            return ws.E_listadoCategoria();
        }



    }
}
