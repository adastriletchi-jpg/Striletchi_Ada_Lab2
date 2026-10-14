using Microsoft.EntityFrameworkCore;

public class Striletchi_Ada_Lab2Context(DbContextOptions<Striletchi_Ada_Lab2Context> options) : DbContext(options)
{
    public DbSet<Striletchi_Ada_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Striletchi_Ada_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Striletchi_Ada_Lab2.Models.Author> Author { get; set; } = default!;
}
