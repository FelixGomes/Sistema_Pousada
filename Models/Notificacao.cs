
namespace sistema_quinta_do_ypua.Models
{
    public class Notificacao
    {
        public string Mensagem { get; set; }

        public string TipoNotificacao { get; set; }

        public Reserva Reserva { get; set; }

        public Hospede Hospede { get; set; }

        public void EnviarNotificacao()
        {
            //TODO logica
        }

    }
}
