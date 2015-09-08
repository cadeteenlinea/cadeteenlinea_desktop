using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Dts;
using Microsoft.SqlServer.Dts.Runtime;

namespace CadeteEnLinea
{
    public class etl
    {
        private string urlPackage;
        private proceso pro;

        public etl(proceso pro) {
            this.pro = pro;
            this.urlPackage = this.pro.nombre_package_etl;
        }


        public bool ejecutar(){
            try
            {
                //Creamos una aplicación para realizar la ejecución
                Microsoft.SqlServer.Dts.Runtime.Application app = new Microsoft.SqlServer.Dts.Runtime.Application();

                //Creamos un paquete y le asignamos el que queremos ejecutar
                //Package package = app.LoadPackage(@"C:\Package_Usuario.dtsx", null);
                Package package = app.LoadPackage(this.urlPackage, null);
                
                //package.Variables
                Microsoft.SqlServer.Dts.Runtime.Variables variables = package.Variables;

                variables["proceso"].Value = _pro.idproceso;

                //Ejecutamos el paquete
                DTSExecResult resultEtl = package.Execute(null, variables, null, null, null);
                //Imprimimos el resultado de la ejecución
                //Console.WriteLine("Resultado de la ejecución: {0}", result.ToString());
                if (resultEtl != Microsoft.SqlServer.Dts.Runtime.DTSExecResult.Success)
                {
                    return false;
                }
                else {
                    return true;
                }
            }
            catch (Exception ex) {
                return false;
            }
        }
    }
}
