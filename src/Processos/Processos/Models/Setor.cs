using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Processos.Models
{
    [Table("SETOR")]
    public class Setor
    {

        [Key]
        public int codigoSetor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome do setor")]
        [Display(Name = "Nome do Setor")]
        public string nome { get; set; }
    }
}
