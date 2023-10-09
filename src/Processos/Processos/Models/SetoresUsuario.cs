using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Processos.Models
{

    [Table("USUARIO_TEM_SETOR")]
    public class SetoresUsuario
    {

        [Key]
      
        public int cpfUsuario { get; set; }

        [Key]
       
        public int codigoSetor { get; set; }


    }
}
