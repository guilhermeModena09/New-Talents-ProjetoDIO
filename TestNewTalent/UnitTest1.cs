using New_Talents;

namespace TestNewTalent
{
    public class UnitTest1
    {

        public Calculadora construirClasse()
        {
            string data = "02/02/2020";
            Calculadora calc = new Calculadora("02/02/2020");

            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9]
        public void TestSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.somar(val1, val2);


            Assert.Equal(resultado, resultadoCalculadora);
        }
        
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.Multiplicar(val1, val2);


            Assert.Equal(resultado, resultadoCalculadora);
        }
        
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.Dividir(val1, val2);


            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TestSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.Subtrair(val1, val2);


            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }
        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();

            calc.somar(1,2);
            calc.somar(2, 8);


            var lista = calc.historico();

            Assert.NotEmpty(calc.historico);
            Assert.Equal(3, lista.Count);
        }
    }
}