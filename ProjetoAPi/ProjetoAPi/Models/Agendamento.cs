namespace ProjetoAPi.Models
{
    public class Agendamento
    {
        public Agendamento() { }
        public string cliente { get; set; }
        public string animal { get; set; }
        public string serviço { get; set; }
        public string funcionario { get; set; }
        public string confirmar { get; set; }
        public string cancelar { get; set; }
    }
}
