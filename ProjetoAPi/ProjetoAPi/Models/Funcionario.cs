using System.Diagnostics.Contracts;

namespace ProjetoAPi.Models
{
    public class Funcionario
    {
        public Guid FuncionarioId { get; set; }
        public string nome { get; set; }
        public string cargo { get; set; }
        public double salario { get; set; }
    }
}
