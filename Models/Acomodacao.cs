using System.ComponentModel.DataAnnotations;

namespace sistema_quinta_do_ypua.Models
{
    public class Acomodacao
    {
        public int Id { get; set; }

        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Cama Solteiro")]
        public int QtdeCamaSolteiro { get; set; }

        [Display(Name = "Cama Casal")]
        public int QtdeCamaCasal { get; set; }

        [Display(Name = "Amenidades")]
        public string Amenidades { get; set; }

        [Display(Name = "Condições")]
        public string Condicoes { get; set; }

        [Display(Name = "Horário Check-In")]
        public int HorarioCheckIn { get; set; }

        [Display(Name = "Horário Check-Out")]
        public int HorarioCheckOut { get; set; }

        [Display(Name = "Valor R$")]
        public Double Valor { get; set; }

        [Display(Name = "Fotos")]
        public List<String> FotosAcomodacao { get; set; }

        //métodos

    }
}
