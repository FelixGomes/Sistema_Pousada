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
    public DbSet<Hospede> Hospede { get; set; }
    public DbSet<Reserva> Reserva { get; set; }
    public DbSet<Acomodacao> Acomodacoe { get; set; }
    public DbSet<Endereco> Endereco { get; set; }
    public DbSet<Funcionario> Funcionario { get; set; }

    public DbSet<Notificacao> Notificacoe { get; set; }
    public DbSet<Pousada> Pousada { get; set; }
    public DbSet<sistema_quinta_do_ypua.Models.Contato> Contato { get; set; }
}
