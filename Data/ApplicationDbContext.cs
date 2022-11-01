using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Parcial2_Oly.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Vitaminas> Vitaminas { get; set; }

    public DbSet<Verduras> Verduras { get; set; }


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Vitaminas>().HasData(
            new Vitaminas{ VitaminaId = 1, Nombre = "Vitamina C"},
            new Vitaminas{ VitaminaId = 2, Nombre = "Betaina"},
            new Vitaminas{ VitaminaId = 3, Nombre = "Vitamina K"},
            new Vitaminas{ VitaminaId = 4, Nombre = "Vitamina A"},
            new Vitaminas{ VitaminaId = 5, Nombre = "Vitamina B"}
        );
    }
}

