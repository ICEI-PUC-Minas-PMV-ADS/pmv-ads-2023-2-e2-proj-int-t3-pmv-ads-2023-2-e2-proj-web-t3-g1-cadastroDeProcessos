using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Processos.Models
{
    [Table("USUARIO")]
    public class Usuario
    {

        [Key]

        [Required(ErrorMessage = "Obrigatório informar o CPF do usuário")]
        [Display(Name = "CPF")]
        public String cpfUsuario { get; set; }


        [Required(ErrorMessage = "Obrigatório informar o nome do usuário")]
        [Display(Name = "Nome do usuário")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha do usuário")]
        [Display(Name = "Senha")]

        public string senha { get; set; }

     
        [Display(Name = "Administrativo?")]

        public bool administrativo{ get; set; }


    }
}
