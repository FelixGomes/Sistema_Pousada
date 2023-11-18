namespace sistema_quinta_do_ypua.Models
{
    public class Acomodacao
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public int QtdeCamaSolteiro { get; set; }
        public int QtdeCamaCasal { get; set; }

        public string Amenidades { get; set; }

        public string Condicoes { get; set; }

        public DateTime HorarioCheckIn { get; set; }

        public DateTime HorarioCheckOut { get; set; }

        public Boolean Disponibilidade { get; set; }

        public Double Valor { get; set; }

        public List<String> FotosAcomodacao { get; set; }

        //métodos

    }
}
