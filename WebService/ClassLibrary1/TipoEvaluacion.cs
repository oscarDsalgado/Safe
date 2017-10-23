using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TipoEvaluacion
    {
        private int id;
        private string nombre;
        private string estado;


        public TipoEvaluacion()
        {

        }

        public TipoEvaluacion(int id, string nombre, string estado)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Estado { get => estado; set => estado = value; }


       
    }
}
