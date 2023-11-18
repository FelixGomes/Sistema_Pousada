using System.ComponentModel.DataAnnotations;


namespace sistema_quinta_do_ypua.Models
{
    public class Pousada
    {
        public int Id { get; set; }
        public string NomePousada { get; set; }

        public Endereco Endereco { get; set; }

        [Required(ErrorMessage = "O email do hóspede é obrigatório", AllowEmptyStrings = false)]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }

    }
}
