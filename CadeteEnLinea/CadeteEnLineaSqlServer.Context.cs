﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CadeteEnLinea
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class cadeteenlineaEntities : DbContext
    {
        public cadeteenlineaEntities()
            : base("name=cadeteenlineaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<apoderado> apoderado { get; set; }
        public DbSet<asignatura> asignatura { get; set; }
        public DbSet<cadete> cadete { get; set; }
        public DbSet<cadete_apoderado> cadete_apoderado { get; set; }
        public DbSet<calificaciones> calificaciones { get; set; }
        public DbSet<ingles_tae> ingles_tae { get; set; }
        public DbSet<notas_finales> notas_finales { get; set; }
        public DbSet<notas_parciales> notas_parciales { get; set; }
        public DbSet<transaccion> transaccion { get; set; }
        public DbSet<usuario> usuario { get; set; }
        public DbSet<proceso> proceso { get; set; }
        public DbSet<tarea> tarea { get; set; }
        public DbSet<errores> errores { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<estadoTarea> estadoTarea { get; set; }
        public DbSet<notas_fisico> notas_fisico { get; set; }
        public DbSet<nivelacion> nivelacion { get; set; }
        public DbSet<francos> francos { get; set; }
    }
}
