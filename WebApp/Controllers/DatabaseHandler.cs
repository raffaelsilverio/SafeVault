using System.Data.SqlClient;

public class DatabaseHandler
{
    private readonly string connectionString = "YourConnectionString";

    public void AddUser(string username, string email, string hashedPassword, string role)
    {
        string query = "INSERT INTO Users (Username, Email, PasswordHash, Role) VALUES (@Username, @Email, @PasswordHash, @Role)";
        using (var connection = new SqlConnection(connectionString))
        using (var command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@PasswordHash", hashedPassword);
            command.Parameters.AddWithValue("@Role", role);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    public string GetStoredHashedPassword(string username)
    {
        string query = "SELECT PasswordHash FROM Users WHERE Username = @Username";
        using (var connection = new SqlConnection(connectionString))
        using (var command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@Username", username);
            connection.Open();
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return reader["PasswordHash"].ToString();
                }
            }
        }
        throw new Exception("User not found.");
    }
}
