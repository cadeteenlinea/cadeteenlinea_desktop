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

        public etl(proceso pro) {
            switch (pro.idproceso)
            {
                case 1:
                    this.urlPackage = @"C:\" + pro.nombre_package_etl;
                    break;
                case 2:
                    break;
            }
        }


        public bool ejecutar(){
            try
            {
                //Creamos una aplicación para realizar la ejecución
                Microsoft.SqlServer.Dts.Runtime.Application app = new Microsoft.SqlServer.Dts.Runtime.Application();
                //Creamos un paquete y le asignamos el que queremos ejecutar
                //Package package = app.LoadPackage(@"C:\Package_Usuario.dtsx", null);
                Package package = app.LoadPackage(this.urlPackage, null);
                //Ejecutamos el paquete
                DTSExecResult resultEtl = package.Execute();
                //Imprimimos el resultado de la ejecución
                //Console.WriteLine("Resultado de la ejecución: {0}", result.ToString());
                if (resultEtl.ToString() != "success")
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
