
namespace sistema_quinta_do_ypua.Models
{
    public class Notificacao
    {
        public int Id { get; set; }
        public string Mensagem { get; set; }

        public TipoNotificacao TipoNotificacao { get; set; }

        public Reserva Reserva { get; set; }

        public Hospede Hospede { get; set; }

        public void EnviarNotificacao()
        {
            //TODO logica
        }

    }

    public enum TipoNotificacao
    {
        ConfirmacaoReserva = 1,
        SoliciatacaoPagamento = 2,
        LembreteCheckIn = 3,
        LembreteCheckOut = 4
    }
}
