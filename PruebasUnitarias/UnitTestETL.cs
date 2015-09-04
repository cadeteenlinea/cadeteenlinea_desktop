using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CadeteEnLinea;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTestETL
    {

        [TestMethod]
        public void TestInsertarTarea()
        {
            DateTime fechaActual = DateTime.Now;
            tarea t = new tarea();
            t.fecha = fechaActual;
            t.hora = new TimeSpan(fechaActual.Hour, fechaActual.Minute, 0);
            t.estado = 1;
            t.proceso_idproceso = 1;
            t.insertar();
        }

        [TestMethod]
        public void TestEjecutarHilo()
        {
            /*proceso pro = new proceso();
            pro.idproceso = 1;
            pro.nombre_package_etl = "Package_Usuario.dtsx";
            etl e = new etl(pro);
            Assert.IsTrue(e.ejecutar());   */

            /*proceso pro = new proceso();
            pro.idproceso = 1;
            pro.nombre_package_etl = @"C:\Package.dtsx";


            DateTime fechaActual = DateTime.Now;
            tarea t = new tarea();
            t.fecha = fechaActual;
            t.hora = new TimeSpan(fechaActual.Hour, fechaActual.Minute, 0);
            t.estado = 0;
            t.proceso = pro;

            t.ejecutarTarea();*/

        }
    }
}
