using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

public class UserController : DbContext
{
    private readonly string _connectionString = "Data Source=DESKTOP-EBBB9JL\\SQLEXPRESS01;Initial Catalog=napelem_rendszer;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

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

    public string TestSqlConnection(string userName)
    {
        using (var context = new UserController())
        {
            var user = context.Users.FirstOrDefault(u => u.Name == userName);

            if (user != null)
            {
                string hashedPassword = BitConverter.ToString(user.Password).Replace("-", "");
                return $"User '{user.Name}' has hashed password '{hashedPassword}'";
            }
            else
            {
                return $"No user found with name '{userName}'";
            }
        }
    }

    public static void LoadDatabaseFromSQLFile(string sqlFilePath, string databaseName)
    {
        string sqlConnectionString = $"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog={databaseName};Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        using (SqlConnection connection = new SqlConnection(sqlConnectionString))
        {
            connection.Open();
            string script = File.ReadAllText(sqlFilePath);
            SqlCommand command = new SqlCommand(script, connection);
            command.ExecuteNonQuery();
            connection.Close();
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