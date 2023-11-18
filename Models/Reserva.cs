using System.ComponentModel.DataAnnotations;

namespace sistema_quinta_do_ypua.Models
{
    public class Reserva
    {
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        //[Display(Name = "Acomodação")]
        //public Acomodacao Acomodacao { get; set; }

        [Display(Name = "Hóspede")]
        public Hospede Hospede { get; set; }

        [Display(Name = "Data de Check-In")]
        public DateTime DataCheckIn{ get; set; }

        [Display(Name = "Data de Check-Out")]
        public DateTime DataCheckOut { get; set; }

        // Métodos para atualizar, criar e cancelar a reserva
        public void AtualizarDataReserva(DateTime novaDataCheckIn, DateTime novaDataCheckOut)
        {
            this.DataCheckIn = novaDataCheckIn;
            this.DataCheckOut = novaDataCheckOut;
        }

        public void CriarReserva()
        {
            // TODO Lógica para criar a reserva
        }

        public void CancelarReserva()
        {
            // TODO Lógica para cancelar a reserva
        }
    }
}
