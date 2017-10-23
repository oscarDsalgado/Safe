using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Detalle_evaluacion
    {
        private string pregunta;
        private int Id_evaluacion;
        private int Id_pregunta;

        public Detalle_evaluacion()
        {

        }
        public Detalle_evaluacion(string pregunta, int id_evaluacion, int id_pregunta)
        {
            this.pregunta = pregunta;
            Id_evaluacion = id_evaluacion;
            Id_pregunta = id_pregunta;
        }

        public string Pregunta { get => pregunta; set => pregunta = value; }
        public int Id_evaluacion1 { get => Id_evaluacion; set => Id_evaluacion = value; }
        public int Id_pregunta1 { get => Id_pregunta; set => Id_pregunta = value; }
    }
}
