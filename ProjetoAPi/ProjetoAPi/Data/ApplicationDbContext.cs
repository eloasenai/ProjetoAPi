using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetoAPi.Models;

namespace ProjetoAPi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        { }

        //definir as tabelas do banco de dados
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        //Sobrescrever o metodo OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Agendamento>().ToTable("Agendamentos");
            modelBuilder.Entity<Animal>().ToTable("Animais");
            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Funcionario>().ToTable("Funcionarios");
            modelBuilder.Entity<Servico>().ToTable("Servicos");


        }
    }
}
