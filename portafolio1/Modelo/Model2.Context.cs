﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities1 : DbContext
    {
        public Entities1()
            : base("name=Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CAPACITACION> CAPACITACION { get; set; }
        public DbSet<EMPRESA> EMPRESA { get; set; }
        public DbSet<EVALUACION> EVALUACION { get; set; }
        public DbSet<EXAMEN> EXAMEN { get; set; }
        public DbSet<MEDICO> MEDICO { get; set; }
        public DbSet<USUARIO> USUARIO { get; set; }
        public DbSet<ATENCION_MEDICA> ATENCION_MEDICA { get; set; }
        public DbSet<EV_EMP> EV_EMP { get; set; }
        public DbSet<US_CAP> US_CAP { get; set; }
    }
}
