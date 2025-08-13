using FluentAssertions;

namespace CalculadoraApp.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Somar_DeveRetornarSomaCorreta()
        {
            // Arrange
            var calc = new CalculadoraApp.Calculadora();

            // Act
            var resultado = calc.Somar(5, 3);

            // Assert
            resultado.Should().Be(8);
        }

        [Fact]
        public void Subtrair_DeveRetornarDiferencaCorreta()
        {
            var calc = new CalculadoraApp.Calculadora();

            var resultado = calc.Subtrair(10, 4);

            resultado.Should().Be(6);
        }

        [Fact]
        public void Multiplicar_DeveRetornarProdutoCorreto()
        {
            var calc = new CalculadoraApp.Calculadora();

            var resultado = calc.Multiplicar(7, 6);

            resultado.Should().Be(42);
        }

        [Fact]
        public void Dividir_ComDivisorZero_DeveLancarExcecao()
        {
            var calc = new CalculadoraApp.Calculadora();

            var acao = () => calc.Dividir(10, 0);

            acao.Should().Throw<DivideByZeroException>()
                .WithMessage("Não é possível dividir por zero.");
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(9, 3, 3)]
        [InlineData(7, 2, 3.5)]
        public void Dividir_DeveRetornarQuocienteEsperado(int a, int b, double esperado)
        {
            var calc = new CalculadoraApp.Calculadora();

            var resultado = calc.Dividir(a, b);

            resultado.Should().Be(esperado);
        }
    }
}
