namespace ProjetoAPi.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }
        public string nome { get; set; }
        public string endereço { get; set; }
        public string telefone { get; set; }
        public string cadastrar { get; set; }
        public string atualizar { get; set; }
    }
}
