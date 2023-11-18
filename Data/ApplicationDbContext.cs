using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sistema_quinta_do_ypua.Models;

namespace sistema_quinta_do_ypua.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Hospede> Hospedes { get; set; }
    public DbSet<Reserva> Reservas { get; set; }
    public DbSet<Acomodacao> Acomodacoes { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }

    public DbSet<Notificacao> Notificacoes { get; set; }
    public DbSet<Pousada> Pousadas { get; set; }
}
