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
    
    public partial class EV_EMP
    {
        public System.DateTime FECHA { get; set; }
        public decimal EVALUACION_ID { get; set; }
        public string EMPRESA_RUT_EMPRESA { get; set; }
        public string OBSERVACION_TECNICO { get; set; }
        public string OBSERVACION_INGENIERO { get; set; }
        public string ESTADO_EV { get; set; }
        public decimal ID_EV { get; set; }
    
        public virtual EMPRESA EMPRESA { get; set; }
        public virtual EVALUACION EVALUACION { get; set; }
    }
}
