using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pregunta
    {
        private int id;
        private string pregunta1;
        private string estado;
        private int cat_id;

        public Pregunta()
        {

        }

        public Pregunta(string pregunta, string estado, int cat_id)
        {
            this.Pregunta1 = pregunta;
            this.Estado = estado;
            this.Cat_id = cat_id;
        }

        public int Id { get => id; set => id = value; }
        public string Pregunta1 { get => pregunta1; set => pregunta1 = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Cat_id { get => cat_id; set => cat_id = value; }
    }
}
