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
    
    public partial class francos
    {
        public int idfrancos { get; set; }
        public Nullable<decimal> cadete_rut { get; set; }
        public string fecha_salida { get; set; }
        public string hora_salida { get; set; }
        public string hora_recogida { get; set; }
        public string fecha_recogida { get; set; }
        public string asignatura_bajo { get; set; }
        public string observaciones { get; set; }
        public Nullable<int> estado { get; set; }
    
        public virtual cadete cadete { get; set; }
    }
}
