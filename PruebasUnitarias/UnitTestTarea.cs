using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CadeteEnLinea;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTestTarea
    {
        tarea tar = new tarea();
        tarea tar2 = new tarea();
        public UnitTestTarea() {
            tar.estado = 1;
            tar.fecha = DateTime.Now;
            tar.hora = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, 0);
            tar.proceso_idproceso = 1;


            tar2.estado = 1;
            tar2.fecha = DateTime.Now;
            tar2.hora = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, 0);
            tar2.proceso_idproceso = 5;
        }

        [TestMethod]
        public void TestAgregarTarea()
        {
            Assert.IsTrue(tar.insertar());
        }

        [TestMethod]
        public void TestActualizarEstado()
        {
            tar.actualizarEstado(2);
            Assert.Equals(tar.estado, 2);
        }

        /*un proceso por minuto*/
        [TestMethod]
        public void TestAgregarTareaFalse()
        {
            Assert.IsFalse(tar2.insertar());
        }

        /*[TestMethod]
        public void TestProximaTareaTrue()
        {
            tarea tar = new tarea();
            Assert.IsNotNull(tar.getProximaTarea());
        }

        [TestMethod]
        public void TestEjecutarTarea()
        {
            tarea tar = new tarea();
            tarea tarEjecutar = tar.getProximaTarea();
            Assert.IsNotNull(tarEjecutar);
            tarEjecutar.ejecutarTarea();
            Assert.Equals(tarEjecutar.estado, 0);
        }*/
    }
}
