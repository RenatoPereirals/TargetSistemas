using TargetSistemas.Domain.Entities;
using TargetSistemas.Domain.Enum;

namespace TargetSistemas.Tests.UnitTests.Domain
{
    public class LancamentoTest
    {
        [Fact]
        public void CriarLancamento_ComSucesso()
        {
            var descricao = "Descricao";
            var dataLancamento = DateTime.Now;
            var valor = 1;
            var avulso = true;
            var status = StatusLancamento.Valido;

            //Act 
            var lancamento = new Lancamento(descricao, dataLancamento, valor, avulso, status);

            //Assert
            Assert.NotNull(lancamento);
            Assert.Equal(descricao, lancamento.Descricao);
            Assert.Equal(dataLancamento, lancamento.DataLancamento);
            Assert.Equal(valor, lancamento.Valor);
            Assert.Equal(avulso, lancamento.Avulso);
            Assert.Equal(status, lancamento.Status);
        }
    }
}