using System.ComponentModel.DataAnnotations;

namespace sistema_quinta_do_ypua.Models
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite a rua e numero, ex.: Rua X, 595", AllowEmptyStrings = false)]
        [Display(Name = "Rua e numero")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "Digite a cidade", AllowEmptyStrings = false)]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Digite o Estado", AllowEmptyStrings = false)]
        [Display(Name = "Estado (UF)")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Digite o código postal (cep)")]
        [Display(Name = "Código postal (cep)")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Digite o País")]
        [Display(Name = "País")]
        public string Pais { get; set; }

    }
}
