using Microsoft.EntityFrameworkCore;

namespace Rest.Data;

public class StudentDataContext : DbContext
{
    private readonly IConfiguration _config;

    
    
    public StudentDataContext(
        DbContextOptions<StudentDataContext>options,IConfiguration configuration):base(options)
    {
        _config = configuration;
    }
    public DbSet<Student> Students{
        get;
        set;
    }

   // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
     //   optionsBuilder.UseSqlite(_config.GetConnectionString("Default Connection"));
    //}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(_config.GetConnectionString("DefaultConnection"))
            .LogTo(Console.WriteLine);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(p =>
        {
            p.ToTable("Students");
            p.HasKey(x => x.StudentId);
        });
    }
}