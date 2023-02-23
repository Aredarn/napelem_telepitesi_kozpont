using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

public class MyDbContext : DbContext
{
    private readonly string _connectionString = "Data Source=DESKTOP-EBBB9JL\\SQLEXPRESS01;Initial Catalog=napelem_rendszer;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(_connectionString);
    }

    public string TestSqlConnection()
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Name=@Name", connection);
            command.Parameters.AddWithValue("@Name", "Alice");
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                // Convert the byte array to a string and update the label text
                string hashedPassword = BitConverter.ToString((byte[])reader["Password"]).Replace("-", "");
                return $"User '{reader["Name"]}' has hashed password '{hashedPassword}'";
            }
            else
            {
                return $"No user found with name 'Alice'";
            }
        }
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public byte[] Password { get; set; }
    public int Role { get; set; }
}
