using System.ComponentModel.DataAnnotations;

namespace sistema_quinta_do_ypua.Models
{
    public class Hospede
    {
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }


        [Required(ErrorMessage = "O nome do hóspede é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome do Hóspede")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O sobrenome do hóspede é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Sobrenome do Hóspede")]
        public string Sobrenome { get; set; }

        [Required]
        [Display(Name = "Número de Telefone. ex: (48) 9999-9999")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Informe o CPF")]
        public string Cpf { get; set; }

        [Required]
        [Display(Name = "Quantidade de pessoas")]
        public int QuantidadePessoas { get; set; }
    }
}
