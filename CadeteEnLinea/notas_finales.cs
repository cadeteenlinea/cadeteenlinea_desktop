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
    
    public partial class notas_finales
    {
        public int idnotas_finales { get; set; }
        public Nullable<decimal> nota_presentacion { get; set; }
        public Nullable<decimal> nota_examen { get; set; }
        public Nullable<decimal> nota_final { get; set; }
        public Nullable<decimal> nota_examen_repeticion { get; set; }
        public Nullable<decimal> nota_final_repeticion { get; set; }
        public string estado { get; set; }
        public Nullable<int> asignatura_idasignatura { get; set; }
        public Nullable<decimal> cadete_rut { get; set; }
        public Nullable<int> estado_tf { get; set; }
    
        public virtual asignatura asignatura { get; set; }
        public virtual cadete cadete { get; set; }
    }
}
