using TargetSistemas.Domain.Enum;

namespace TargetSistemas.Domain.Entities
{
    public class Lancamento
    {
        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataLancamento { get; private set; }
        public decimal Valor { get; private set; }
        public bool Avulso { get; private set; }
        public StatusLancamento Status { get; private set; }

        public Lancamento(string descricao, DateTime dataLancamento, decimal valor, bool avulso, StatusLancamento status)
        {
            Descricao = descricao ?? throw new ArgumentNullException(nameof(descricao));
            DataLancamento = dataLancamento;
            Valor = valor;
            Avulso = avulso;
            Status = status;
        }
    }
}