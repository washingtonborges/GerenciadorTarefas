using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorTarefas.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Email incorreto, favor digite um email válido.")]
        public string Email { get; set; }
        [Required]
        public string Permissao { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}