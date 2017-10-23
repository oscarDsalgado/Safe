using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class categoria
    {
        private int id;
        private string nombre;
        private string estado;
        private int idTipo;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Estado { get => estado; set => estado = value; }
        public int IdTipo { get => idTipo; set => idTipo = value; }

        public categoria()
        {

        }
        public categoria(int id, string nombre, string estado, int idTipo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Estado = estado;
            this.IdTipo = idTipo;
        }
    }
}
