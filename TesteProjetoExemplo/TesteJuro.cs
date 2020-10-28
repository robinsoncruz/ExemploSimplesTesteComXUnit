using ProjetoExemplo;
using Xunit; 

namespace TesteProjetoExemplo
{
    public class TesteJuro
    {
        readonly Juro juro = new Juro();

        [Fact]
        void TesteJuroComposto()
        {
            juro.juro = 2d;
            juro.capital = 1000d;
            juro.meses = 2;
            juro.CalcularJuroComposto();
            Assert.Equal(1040.40d, juro.resultado);
        }

        [Fact]
        void TesteJuroSimples()
        {
            juro.juro = 2d;
            juro.capital = 1000d;
            juro.meses = 2;
            juro.CalcularJuroSimples();
            Assert.Equal(1040d, juro.resultado);
        }
    }
}


