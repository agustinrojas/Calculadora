﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [DataRow(4,2,2)]
        [DataRow(9,3,3)]
        [DataTestMethod]
        public void DivisionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Division(num1, num2)==resultado);
        }

        [DataRow(4, 4, 16)]
        [DataRow(3, 3, 9)]
        [DataTestMethod]
        public void MultiplicacionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Multiplicacion(num1, num2) == resultado);
        }

        [DataRow(4, 4, 0)]
        [DataRow(9, 3, 6)]
        [DataTestMethod]
        public void RestaTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Resta(num1, num2) == resultado);
        }

        [DataRow(4, 4, 8)]
        [DataRow(9, 3, 12)]
        [DataTestMethod]
        public void SumaTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Suma(num1, num2) == resultado);
        }
    }
}