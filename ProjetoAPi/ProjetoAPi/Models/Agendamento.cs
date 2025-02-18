namespace ProjetoAPi.Models
{
    public class Agendamento
    {
        public Guid AgendamentoId { get; set; }

        public Guid ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        public Guid AnimalId { get; set; }
        public Animal? Animal { get; set; }

        public Guid FuncionarioId { get; set; }
        public Funcionario? Funcionario { get; set; }

        public Guid ServicoId { get; set; }
        public Servico? Servico { get; set; }

    }
}
