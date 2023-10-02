using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Processos.Models
{

    [Table("MOVIMENTACAO")]
    public class Movimentacao
    {

        [Key]
        [Display(Name = "Código")]
        public int codigoMovimentacao{ get; set; }


        [Display(Name = "Processo")]
        public int codigoProcesso { get; set; }


        [Display(Name = "Data/Hora")]
        public DateTime dataHora { get; set; }


        [Display(Name = "Usuário")]
        public string cpfUsuarioTramite { get; set; }


        [Display(Name = "Localização")]
        public int codigoSetorLocalizacao { get; set; }



    }
}
