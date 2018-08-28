using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorTarefas.Models
{
    public class Perfil
    {      
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PerfilId { get; set; }
        [Required]
        public string Nome { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }

}