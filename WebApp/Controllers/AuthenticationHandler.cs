using BCrypt.Net;

public class AuthenticationHandler
{
    private readonly DatabaseHandler dbHandler = new DatabaseHandler();

    public string HashPassword(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }

    public bool AuthenticateUser(string username, string password)
    {
        string storedHashedPassword = dbHandler.GetStoredHashedPassword(username);
        return BCrypt.Net.BCrypt.Verify(password, storedHashedPassword);
    }
}
