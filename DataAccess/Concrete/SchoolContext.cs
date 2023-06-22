using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete;

public class SchoolContext :DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Database=SchoolData;Username=postgres;Password=123123");
}