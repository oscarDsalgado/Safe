using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class capacitacion
    {
        private int id;
        private string area;
        private string fecha;
        private string tema;
        private string expositor;
        private int asistencia;
        private string rut_empresa;
        private string tipo_cap;

        public capacitacion() { 
        
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Area
        {
            get { return area; }
            set { area = value; }
        }
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string Tema
        {
            get { return tema; }
            set { tema = value; }
        }
        public string Expositor
        {
            get { return expositor; }
            set { expositor = value; }
        }
        public int Asistencia
        {
            get { return asistencia; }
            set { asistencia = value; }
        }
        public string Rut_empresa
        {
            get { return rut_empresa; }
            set { rut_empresa = value; }
        }
        public string Tipo_cap
        {
            get { return tipo_cap; }
            set { tipo_cap = value; }
        }
    }
}
