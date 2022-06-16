using CalculadoraIMC;
using Xunit;

namespace TesteCalculadoraIMC
{
    public class TesteCalculoIMC
    {
        [Fact]
        public void CalcularIMC()
        {
            //Arrange
            double peso = 75;
            double altura = 1.6;
            double imc = 29.3;

            //Act
            var resultadoIMC = CalculoIMC.CalcularIMC(peso, altura);

            //Assert
            Assert.Equal(imc, resultadoIMC);
        }

        [Theory]
        [InlineData(50, 1.68, 17.72)]
        [InlineData(76, 1.75, 24.82)]
        [InlineData(100, 1.60, 39.06)]

        public void CalcularIMCLista(double peso, double altura, double imc)
        {
            //Act
            var resultadoIMC = CalculoIMC.CalcularIMC(peso, altura);

            //Assert
            Assert.Equal(imc, resultadoIMC);
        }
    }
}