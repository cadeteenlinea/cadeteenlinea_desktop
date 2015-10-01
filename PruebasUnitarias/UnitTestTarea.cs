using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CadeteEnLinea;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTestTarea
    {

        private static cadeteenlineaEntities conexion = new cadeteenlineaEntities();


        [TestMethod]
        public void TestProximaTareaTrue()
        {
            tarea tar = new tarea();
            Assert.IsNotNull(tar.getProximaTarea());
        }

        [TestMethod]
        public void TestTareaEnEjecucion()
        {
            tarea tar = 
            Assert.IsNotNull(tar);

            
        }

        [TestMethod]
        public void TestEjecutarTarea()
        {
            tarea tar = tarea.getProximaTarea();
            Assert.IsNotNull(tar);

            tar.ejecutarTarea();
        }
    }
}
