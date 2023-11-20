namespace sistema_quinta_do_ypua.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public NivelAcesso NivelAcesso { get; set; }
    }

    public enum NivelAcesso
    {
        Admin = 1,
        Gerente = 2,
        Funcionario = 3
    }
}
