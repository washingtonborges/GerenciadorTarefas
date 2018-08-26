namespace GerenciadorTarefas.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Permissao { get; set; }
        public string Senha { get; set; }
    }
}