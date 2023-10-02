using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Processos.Models
{
    [Table("FLUXO")]
    public class Fluxo
    {

        [Key]

        public int codigoFluxo{ get; set; }

        [Display(Name = "Setor de Origem")]
        public int codigoSetorOrigem { get; set; }

        [Display(Name = "Setor de Destino")]
        public int codigoSetorDestino { get; set; }

        [Display(Name = "Tipo de Processo")]
        public int codigoTipoProcesso { get; set; }

    }
}
