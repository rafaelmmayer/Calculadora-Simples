using System;
using Xunit;
using CalculadoraLibrary;

namespace CalculadoraSimplesTeste
{
    public class Testes
    {
        [Theory]
        [InlineData(5, 5)]
        [InlineData(10, 0)]
        [InlineData(-5, 2)]
        [InlineData(6, -3)]
        public void Somar_SomaDeValores(double x, double y)
        {
            //Arrange
            double expected = x + y;

            //Act
            double actual = Operacoes.Somar(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5)]
        [InlineData(10, 0)]
        [InlineData(-5, 2)]
        [InlineData(6, -3)]
        public void Subtrair_SubtracaoDeValores(double x, double y)
        {
            //Arrange
            double expected = x - y;

            //Act
            double actual = Operacoes.Subtrair(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5)]
        [InlineData(10, 0)]
        [InlineData(-5, 2)]
        [InlineData(6, -3)]
        public void Multiplicar_MultiplicacaoDeValores(double x, double y)
        {
            //Arrange
            double expected = x * y;

            //Act
            double actual = Operacoes.Multiplicar(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, 2)]
        [InlineData(6, -3)]
        public void Dividir_DivisaoDeValores(double x, double y)
        {
            //Arrange
            double expected = x / y;

            //Act
            double actual = Operacoes.Dividir(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("A", "5")]
        [InlineData("b", "c")]
        public void ValidacaoNum1_ValidarValor1(string x, string y)
        {
            //Arrange
            string expected = "Valor 1 inválido";

            //Act
            string actual = Operacoes.ValidacaoNums(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("5", "A")]
        [InlineData("3", "b")]
        public void ValidacaoNum2_ValidarValor2(string x, string y)
        {
            //Arrange
            string expected = "Valor 2 inválido";

            //Act
            string actual = Operacoes.ValidacaoNums(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
