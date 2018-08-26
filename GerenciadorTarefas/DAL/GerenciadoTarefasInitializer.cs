using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GerenciadorTarefas.Models;

namespace GerenciadorTarefas.DAL
{
    public class GerenciadorTarefasInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<GerenciadorTarefasContext>
    {
        protected override void Seed(GerenciadorTarefasContext context)
        {
            var usuarios = new List<Usuario>
            {
            new Usuario{Nome="admin", Email="admin@admin.br", Permissao="Administrador", Senha="admin"}
            };

            usuarios.ForEach(s => context.Usuario.Add(s));
            context.SaveChanges();

            var tarefas = new List<Tarefa>
            {
            new Tarefa{Titulo="Primeira tarefa",Concluida=false},
            new Tarefa{Titulo="Segunda tarefa",Concluida=true}
            };

            tarefas.ForEach(s => context.Tarefa.Add(s));
            context.SaveChanges();

        }
    }
}