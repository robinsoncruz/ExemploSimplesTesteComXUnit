using Xunit;
using ProjetoExemplo;
namespace TesteProjetoExemplo
{
    public class TesteAnalisa
    {
        readonly Analisa analisa = new Analisa();
        
        [Theory]
        [InlineData(3,2)]
        [InlineData(10,2)]
        void TestarAMaiorDoQueB(int A, int B){
            bool resultado = analisa.Analisar(A, B);
            Assert.True(true, $"{A} é maior do que {B}.");
        }

        [Theory]
        [InlineData(1, 6)]
        [InlineData(0, 5)]
        void TestarBMenorOuIgualB(int A, int B)
        {
            bool resultado = analisa.Analisar(A, B);
            Assert.Equal(false, resultado);
        }

    }
}




