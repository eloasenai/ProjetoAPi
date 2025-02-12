namespace ProjetoAPi.Models
{
    public class Animal
    {
        public Guid AnimalId { get; set; }
        public string Tipo { get; set; }
        public string Raca { get; set; }
        public double Peso { get; set; }
        public string Pelagem { get; set; }
        public string Tamanho { get; set; }
        public int Idade { get; set; }
    }
}
