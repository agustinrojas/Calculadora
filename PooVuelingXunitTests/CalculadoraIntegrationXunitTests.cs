using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using PooVueling;




namespace PooVuelingXunitTests
{
    public class CalculadoraIntegrationXunitTests
    {
        ICalculadora iCalculadora = new Calculadora();

        [Fact]
        public void SumaTest()
        {
            Assert.Equal(10, iCalculadora.Suma(5, 5));
        }

        [Fact]
        public void RestaTest()
        {
            Assert.Equal(1, iCalculadora.Resta(4, 3));
        }

        [Fact]
        public void DivisionTest()
        {
            Assert.False(6 == iCalculadora.Division(24, 3));
        }

        [Fact]
        public void MultiplicacionTest()
        {
            Assert.True(4 == iCalculadora.Multiplicacion(2, 2));
        }
    }
}
