//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class nivelacion
    {
        public int idnivelacion { get; set; }
        public Nullable<decimal> cadete_rut { get; set; }
        public Nullable<decimal> ano { get; set; }
        public Nullable<decimal> semestre { get; set; }
        public Nullable<decimal> etapa { get; set; }
        public Nullable<decimal> marca_100_mt { get; set; }
        public Nullable<decimal> marca_1000_mt { get; set; }
        public Nullable<decimal> marca_salto_largo { get; set; }
        public Nullable<decimal> marca_bala { get; set; }
        public Nullable<decimal> marca_100_libre { get; set; }
        public Nullable<decimal> marca_bajo_agua { get; set; }
        public Nullable<decimal> marca_trepa { get; set; }
        public Nullable<decimal> marca_abdominales { get; set; }
        public Nullable<decimal> marca_extension_brazos { get; set; }
        public Nullable<decimal> marca_cooper { get; set; }
        public Nullable<decimal> nota_100_mt { get; set; }
        public Nullable<decimal> nota_1000_mt { get; set; }
        public Nullable<decimal> nota_salto_largo { get; set; }
        public Nullable<decimal> nota_bala { get; set; }
        public Nullable<decimal> nota_100_libre { get; set; }
        public Nullable<decimal> nota_bajo_agua { get; set; }
        public Nullable<decimal> nota_trepa { get; set; }
        public Nullable<decimal> nota_abdominales { get; set; }
        public Nullable<decimal> nota_extension_brazos { get; set; }
        public Nullable<decimal> nota_final { get; set; }
        public string observacion { get; set; }
        public Nullable<int> estado { get; set; }
    
        public virtual cadete cadete { get; set; }
    }
}