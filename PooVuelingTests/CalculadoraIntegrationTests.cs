using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling.Tests
{
    [TestClass()]
    public class CalculadoraIntegrationTests
    {
        ICalculadora iCalculadora = new Calculadora();

        [TestMethod()]
        public void DivisionTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MultiplicacionTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RestaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SumaTest()
        {
            //.net su framework tiene una case que se llama assrt con un metodo estatco IsTrue, que comprueba que la condicion que le pasa sea verdadera
            Assert.IsTrue(iCalculadora.Suma(2, 2) == 4);
            //Assert.Fail();
        }
    }
}