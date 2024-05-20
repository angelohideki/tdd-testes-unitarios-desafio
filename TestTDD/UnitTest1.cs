using ProjectTDD;
using System;
using Xunit;

namespace TestTDD
{
    public class UnitTest1
    {
        public Calculadora construirClasse()
        {
            string data = DateTime.Now.ToString("dd-MM-yyyy");

           Calculadora calculadora = new Calculadora(data);

           return calculadora;

        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestSomar(int val1, int val2, int resultado)
        {
            Calculadora calculadora = construirClasse();

            int resultadoCalculadora = calculadora.Somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(5, 3, 2)]
        public void TestSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calculadora = construirClasse();

            int resultadoCalculadora = calculadora.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calculadora = construirClasse();

            int resultadoCalculadora = calculadora.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(4, 2, 2)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora calculadora = construirClasse();

            int resultadoCalculadora = calculadora.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calculadora = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calculadora.Dividir(3,0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calculadora = construirClasse();

            calculadora.Somar(1, 2);
            calculadora.Somar(2, 3);
            calculadora.Somar(3, 4);
            calculadora.Somar(4, 5);

            var lista = calculadora.Historico();
            Assert.NotEmpty(calculadora.Historico());
            Assert.Equal(3, lista.Count);
        }
    }
}
