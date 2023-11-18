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
}
