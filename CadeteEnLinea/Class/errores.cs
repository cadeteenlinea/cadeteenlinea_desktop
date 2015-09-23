using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace CadeteEnLinea
{
    public partial class errores
    {
        /*public String codigo { get; set; }
        public String idRegistro { get; set; }
        public String tabla { get; set; }
        public String error { get; set; }*/

        
        private static cadeteenlineaEntities conexion = new cadeteenlineaEntities();


        /*recibe los errores de la ejecucion las tareas realizadas
           estos son guardados en una tabla llamada error, relacionada con la tabla tarea
         */
        public static void setErrors(string errores)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            var re = jss.DeserializeObject(errores);
            List<errores> result = new List<errores>();
            if (Convert.ToString(re) != String.Empty)
            {
                if (re != " \\")
                {
                    result.AddRange(jss.Deserialize<List<errores>>(errores));
                }
                tarea tarea = new tarea();
                tarea tar = tarea.tareaEnEjecucion();
                foreach (errores s in result)
                {
                    s.tarea_idTarea = tar.idtarea;
                    conexion.errores.Add(s);
                    conexion.SaveChanges();
                }
            }
        }

        public static List<dynamic> getAllErroresTarea(int idtarea)
        {
            //var tar = conexion.tarea.Where(p => p.estado == 1).ToList();

            var tarea = conexion.errores.Where(p=> p.tarea_idTarea == idtarea).Select(p => new
            {
                //idtarea = p.codigo,
                codigo = p.codigo,
                tabla = p.tabla,
                registro = p.idRegistro,
                error = p.error
            }).ToList();

            return tarea.ToList<dynamic>();
        }
        
        /*guarda el error instanciado*/
        public void guardar() {
            conexion.errores.Add(this);
            conexion.SaveChanges();
        }
    }
}
