using GerenciadorTarefas.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GerenciadorTarefas.DAL
{
    public class GerenciadorTarefasContext : DbContext
    {

        public GerenciadorTarefasContext() : base("GerenciadorTarefasContext")
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Tarefa> Tarefa { get; set; }
        public DbSet<Perfil> Perfil { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}