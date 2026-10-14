using Microsoft.EntityFrameworkCore;

public class Niste_Marius_Lab2Context(DbContextOptions<Niste_Marius_Lab2Context> options) : DbContext(options)
{
    public DbSet<Niste_Marius_Lab2.Models.Book> Book { get; set; } = default!;
}
