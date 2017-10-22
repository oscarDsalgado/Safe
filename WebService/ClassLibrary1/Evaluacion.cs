using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public  class Evaluacion
    {
        private int id;
        private DateTime fecha;
        private string obstec;
        private string obsing;
        private string estado;
        private int id_tipo;
        private int id_empresa;
        private int id_usuario;

        public Evaluacion(int id, DateTime fecha, string obstec, string obsing, string estado, int id_tipo, int id_empresa, int id_usuario)
        {
            this.Id = id;
            this.Fecha = fecha;
            this.Obstec = obstec;
            this.Obsing = obsing;
            this.Estado = estado;
            this.Id_tipo = id_tipo;
            this.Id_empresa = id_empresa;
            this.Id_usuario = id_usuario;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Obstec { get => obstec; set => obstec = value; }
        public string Obsing { get => obsing; set => obsing = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
        public int Id_empresa { get => id_empresa; set => id_empresa = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
    }
}
