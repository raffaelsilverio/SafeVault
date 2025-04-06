public class AuthorizationHandler
{
    private readonly DatabaseHandler dbHandler = new DatabaseHandler();

    public bool HasAccess(string username, string requiredRole)
    {
        string userRole = GetUserRole(username);
        return userRole == requiredRole;
    }

    private string GetUserRole(string username)
    {
        string query = "SELECT Role FROM Users WHERE Username = @Username";
        using (var connection = new SqlConnection(dbHandler.ConnectionString))
        using (var command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@Username", username);
            connection.Open();
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return reader["Role"].ToString();
                }
            }
        }
        throw new Exception("User not found.");
    }
}
