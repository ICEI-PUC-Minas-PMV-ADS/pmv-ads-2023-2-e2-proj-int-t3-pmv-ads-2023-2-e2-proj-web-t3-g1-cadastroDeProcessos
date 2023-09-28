using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Processos.Models
{
    [Table("TIPO_PROCESSO")]
    public class Tipo_Processo
    {

        [Key]
        public int codigoTipoProcesso { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome do tipo de processo")]
        [Display(Name = "Tipo de Processo")]
        public string nomeTipoProcesso { get; set; }
    }
}
