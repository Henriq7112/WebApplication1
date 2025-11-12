using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o nome")]  
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a senha")]
        [DataType(DataType.Password)]   
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o tipo de usuário")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Admin,
        User
    }
}