//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo3
{
    using System;
    using System.Collections.Generic;
    
    public partial class EXAMEN
    {
        public EXAMEN()
        {
            this.ATENCION_MEDICA = new HashSet<ATENCION_MEDICA>();
        }
    
        public decimal ID_EVALUACION { get; set; }
        public string TIPO { get; set; }
        public string ESTADO { get; set; }
    
        public virtual ICollection<ATENCION_MEDICA> ATENCION_MEDICA { get; set; }
    }
}
