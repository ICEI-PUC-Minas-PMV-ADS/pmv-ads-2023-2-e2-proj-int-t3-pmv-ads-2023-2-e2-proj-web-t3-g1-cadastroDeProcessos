using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Processos.Models
{
    [Table("INTERESSADO")]
    public class Interessado
    {

        [Key]

        public int codigoInteressado { get; set; }


        [Required(ErrorMessage = "Obrigatório informar o CPF/CNPJ do interessado")]
        [Display(Name = "CPF/CNPJ")]

        public string? cpfCnpjInteressado { get; set; }


        [Required(ErrorMessage = "Obrigatório informar o nome ou razão social do interessado")]
        [Display(Name = "Nome / Razão Social")]
        public string nome { get; set; }

        [Display(Name = "E-mail")]
        public string? email { get; set; }

        [Display(Name = "Telefone")]
        public string? telefone { get; set; }

        [Display(Name = "Logradouro")]
        public string? logradouro { get; set; }

        [Display(Name = "Número")]
        public string? numero { get; set; }

        [Display(Name = "Complemento")]
        public string? complemento { get; set; }

        [Display(Name = "Bairro")]
        public string? bairro { get; set; }

        [Display(Name = "Cidade")]
        public string? cidade { get; set; }

        [Display(Name = "UF")]
        public string? uf { get; set; }

        [Display(Name = "País")]
        public string? pais { get; set; }
        [Display(Name = "CEP")]
        public string? cep { get; set; }


    }
}
