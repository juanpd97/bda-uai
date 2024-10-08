using BdaUai.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Si en el futuro necesitas agregar más tablas, las definirás aquí.
    // Ejemplo: public DbSet<Book> Books { get; set; }
}
