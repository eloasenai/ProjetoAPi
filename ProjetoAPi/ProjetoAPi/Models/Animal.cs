﻿namespace ProjetoAPi.Models
{
    public class Animal
    {
        public Guid AnimalId { get; set; }
        public string nome { get; set; }
        public string especie { get; set; }
        public int idade { get; set; }
        public string cadastrar { get; set; }
        public string atualizar { get; set; }

    }
}
