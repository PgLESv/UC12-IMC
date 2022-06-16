using CalculadoraIMC;
using Xunit;

namespace TesteCalculadoraIMC
{
    public class TesteClassificacaoIMC
    {
        [Fact]
        public void ClassificarIMC()
        {
            //Arrange
            double imc = 24.0;
            string classificacao = "Peso normal.";

            //Act
            var classificacaoIMC = CalculoIMC.ClassificarIMC(imc);

            //Assert
            Assert.Equal(classificacao, classificacaoIMC);
        }

        [Theory]
        [InlineData(18.0, "Abaixo do peso.")]
        [InlineData(20.0, "Peso normal.")]
        [InlineData(27.5, "Sobrepeso.")]
        [InlineData(31.7, "Obesidade Grau I.")]
        [InlineData(39.8, "Obesidade Grau II.")]
        [InlineData(44.5, "Obesidade Grau III.")]
        public void ClassificarIMCLista(double imc, string classificacao)
        {
            //Act
            var classificacaoIMC = CalculoIMC.ClassificarIMC(imc);

            //Assert
            Assert.Equal(classificacao, classificacaoIMC);
        }
    }
}