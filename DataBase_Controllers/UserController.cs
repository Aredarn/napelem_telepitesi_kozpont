using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

public class UserController : DbContext
{
    private readonly string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true";

    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(_connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>().HasKey(u => u.Name);
    }

    public int TestSqlConnection(string name)
    {
        using (var context = new UserController())
        {
            var user = context.Users.FirstOrDefault(u => u.Name == name);
            if (user != null)
            {
                return user.Role;
            }
            else
            {
                return -1;
            }
        }
    }

}

public class User
{
    [Key]
    public string Name { get; set; }
    public byte[] Password { get; set; }
    public int Role { get; set; }
}