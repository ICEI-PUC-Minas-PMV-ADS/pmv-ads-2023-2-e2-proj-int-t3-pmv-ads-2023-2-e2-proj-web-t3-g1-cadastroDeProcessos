using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Processos.Models
{
    [Table("ANEXO_PROCESSO")]
    public class AnexoProcesso
    {

        [Key]

        public int codigoAnexo{ get; set; }

        public int codigoProcesso { get; set; }

        public DateTime dataHora { get; set; }

        public string nomeAnexo { get; set; }

    }
}
