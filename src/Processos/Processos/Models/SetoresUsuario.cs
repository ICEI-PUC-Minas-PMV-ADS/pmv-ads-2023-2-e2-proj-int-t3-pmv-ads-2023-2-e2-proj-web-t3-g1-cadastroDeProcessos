using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Processos.Models
{

    [Table("USUARIO_TEM_SETOR")]
    public class SetoresUsuario
    {


        [Key]
        public int sequencial { get; set; }


        public String cpfUsuario { get; set; }

    

        public int codigoSetor { get; set; }


    }
}
