namespace ProjetoAPi.Models
{
    public class Horario
    {
        public Guid HorarioId { get; set; }
        public Guid AnimalId { get; set; }
        public Animal? Animal { get; set; }
        public DateTime Data { get; set; }

    }
}
