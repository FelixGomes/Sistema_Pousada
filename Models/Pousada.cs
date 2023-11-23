using System.ComponentModel.DataAnnotations;


namespace sistema_quinta_do_ypua.Models
{
    public class Pousada
    {
        public int Id { get; set; }

        [Display(Name = "Nome da Pousada")]
        public string NomePousada { get; set; }

        [Display(Name = "Endereço")]
        public Endereco Endereco { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

    }
}
