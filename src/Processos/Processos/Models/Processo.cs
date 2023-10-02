using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Processos.Models
{
    [Table("PROCESSO")]
    public class Processo
    {

        [Key]
        [Display(Name = "Código")]
        public int codigoProcesso{ get; set; }


        [Display(Name = "Interessado")]
        public int codigoInteressado{ get; set; }


        [Display(Name = "Tipo de Processo")]
        public int codigoTipoProcesso{ get; set; }


        [Display(Name = "Protocolista")]
        public String cpfProtocolista { get; set; }


        [Display(Name = "Setor")]
        public int codigoSetor { get; set; }


        [Display(Name = "Data/Hora")]
        public DateTime dataHora { get; set; }


        [Display(Name = "Resumo")]
        public String resumo { get; set; }


        [Display(Name = "Assunto")]
        public String assunto { get; set; }


    }
}
