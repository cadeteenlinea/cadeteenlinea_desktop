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
    
    public partial class notas_parciales
    {
        public int idnotas_parciales { get; set; }
        public Nullable<decimal> cadete_rut { get; set; }
        public Nullable<decimal> nota { get; set; }
        public Nullable<decimal> dia { get; set; }
        public Nullable<decimal> mes { get; set; }
        public Nullable<decimal> ano { get; set; }
        public Nullable<decimal> semestre { get; set; }
        public Nullable<int> asignatura_idasignatura { get; set; }
        public string tipo { get; set; }
        public Nullable<decimal> nNota { get; set; }
        public Nullable<int> estado { get; set; }
    
        public virtual asignatura asignatura { get; set; }
        public virtual cadete cadete { get; set; }
    }
}
