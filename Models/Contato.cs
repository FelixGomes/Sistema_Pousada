using System.ComponentModel.DataAnnotations;

namespace sistema_quinta_do_ypua.Models
{
    public class Contato
    {
        public int Id { get; set;}
        public string Nome { get; set;}

        [Display(Name = "E-mail")]
        public string Email { get; set;}
        public string Telefone { get; set;}
        public string Mensagem { get; set;}
    }
}
